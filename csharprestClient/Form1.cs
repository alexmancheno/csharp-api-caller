using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace csharprestClient
{

    public partial class GoogleApiCaller : Form
    {
        private bool autoWrite = false;
        private Dictionary<string, autoWriter> threadDictionary = new Dictionary<string, autoWriter>();
        //dictionary which holds the available API's
        private Dictionary<string, string> apiDictionary = new Dictionary<string, string>();
        //apiDictionary.

        public GoogleApiCaller()
        {
            InitializeComponent();
            apiDictionary.Add("Google Finance", "https://www.google.com/finance/getprices?i=[PERIOD]&p=[DAYS]d&f=d,o,h,l,c,v&def=cpct&q=[TICKER]");
            apiDictionary.Add("Yahoo Finance", "http://chartapi.finance.yahoo.com/instrument/1.0/[TICKER]/chartdata;type=quote;range=1d/json");
        }

        #region UI Event Handlers

        private void cmdGO_Click(object sender, EventArgs e)
        {
            Regex numsOnly = new Regex("^[0-9]*");


            if (!threadDictionary.ContainsKey(txtFileName.Text))
            {

                //replace substrings with user input from the desktop gui
                string selectedRequest = apiDictionary[comboBoxOptions.Text];
                selectedRequest = selectedRequest.Replace("[TICKER]", txtTicker.Text);
                if (apiDictionary[comboBoxOptions.Text].Contains("[DAYS]"))
                    selectedRequest = selectedRequest.Replace("[DAYS]", txtDays.Text);

                if (apiDictionary[comboBoxOptions.Text].Contains("[PERIOD]"))
                    selectedRequest = selectedRequest.Replace("[PERIOD]", txtInterval.Text);


                //create RestClient object and set the endpoint w/ user input
                RestClient rClient = new RestClient();
                rClient.endPoint = selectedRequest;

                //make the request to the API and retrieve response
                HttpWebResponse response = (HttpWebResponse)rClient.makeRequest();

                //write to file after retrieving response from API
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    debugOutPut("Http request to " + comboBoxOptions.Text + ": " + response.StatusCode.ToString());
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                using (StreamWriter sw = File.CreateText(txtFilePath.Text + txtFileName.Text))
                                {
                                    string currentLine = string.Empty;
                                    debugOutPut("File created succesfully at: " + txtFilePath.Text);
                                    while (currentLine != null)
                                    {
                                        currentLine = reader.ReadLine();
                                        sw.WriteLine(currentLine);
                                    }
                                    debugOutPut("Finished writing to " + txtFilePath.Text + txtFileName.Text);
                                }
                            }
                        }
                    }
                }

                if (autoWrite)
                {
                    string ep = apiDictionary[comboBoxOptions.Text];
                    ep = ep.Replace("[TICKER]", txtTicker.Text);

                    if (apiDictionary[comboBoxOptions.Text].Contains("[DAYS]"))
                        ep = ep.Replace("[DAYS]", "1");

                    if (apiDictionary[comboBoxOptions.Text].Contains("[PERIOD]"))
                        ep = ep.Replace("[PERIOD]", txtInterval.Text);

                    rClient.endPoint = ep;

                    string filePath = txtFilePath.Text + txtFileName.Text;
                    int interval = 0, i = 0;
                    Int32.TryParse(txtInterval.Text, out interval);

                    threadDictionary.Add(txtFileName.Text, new autoWriter(rClient, filePath, interval));
                    threadDictionary[txtFileName.Text].updateFilePeriodically();

                    ListViewItem item = new ListViewItem(txtFileName.Text);
                    item.SubItems.Add(txtFilePath.Text);
                    item.SubItems.Add(txtInterval.Text);
                    item.SubItems.Add(txtDays.Text);
                    item.SubItems.Add(txtTicker.Text);
                    item.SubItems.Add(comboBoxOptions.Text);
                    item.SubItems.Add(DateTime.Now.ToString("h:mm:ss tt"));

                    listActiveFiles.Items.Add(item);
                }
            }

            else
            {

            }
        }


        #endregion

        public void debugOutPut(string strDebugText)
        {
            try
            {
                //System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();
            }
            catch (Exception ex)
            {
                //System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void GoogleApiCaller_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.RootFolder = Environment.SpecialFolder.Desktop;
                fbd.Description = "Select a folder where the *.txt file will be saved";
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    txtFilePath.Text = fbd.SelectedPath + "\\";
            } catch (Exception ex)
            {
                debugOutPut("There was an error selecting the file: " + ex.ToString());
            } 

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            autoWrite = true;
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            autoWrite = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listActiveFiles.Items.Count > 0)
            {
                try
                {
                    ListViewItem item = listActiveFiles.SelectedItems[0];
                    string fileName = item.SubItems[0].Text;
                    debugOutPut(fileName);
                    threadDictionary[fileName].stopUpdating();
                    threadDictionary.Remove(fileName);
                    listActiveFiles.Items.Remove(item);
                } 
                catch (Exception ex)
                {
                    debugOutPut("There was an error killing the process: " + ex.ToString());
                }
            }

            
        }

        private void lblListFilePath_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.RootFolder = Environment.SpecialFolder.Desktop;
                fbd.Description = "Select a folder where the *.txt file will be saved";
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    txtSaveLocation.Text = fbd.SelectedPath + "\\";
            }
            catch (Exception ex)
            {
                debugOutPut("There was an error selecting the save location: " + ex.ToString());
            }
        }

        private void btnSelectListFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtListFile.Text = ofd.FileName.ToString();
                }
            }
            catch (Exception ex)
            {
                debugOutPut("There was an error selecting the list file: " + ex.ToString());
            }
        }

        private void btnCreateRecords_Click(object sender, EventArgs e)
        {

        }
    }
}
