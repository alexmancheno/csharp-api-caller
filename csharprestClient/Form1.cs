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

namespace csharprestClient
{

    public partial class GoogleApiCaller : Form
    {

        public GoogleApiCaller()
        {
            InitializeComponent();
        }

        bool autoWrite = false;
        List<autoWriter> list = new List<autoWriter>();

        #region UI Event Handlers

        private void cmdGO_Click(object sender, EventArgs e)
        {
            //dictionary which holds the available API's
            Dictionary<string, string> apiList = new Dictionary<string, string>();
            apiList.Add("Google Finance", "https://www.google.com/finance/getprices?i=[PERIOD]&p=[DAYS]d&f=d,o,h,l,c,v&def=cpct&q=[TICKER]");
            apiList.Add("Yahoo Finance", "http://chartapi.finance.yahoo.com/instrument/1.0/[TICKER]/chartdata;type=quote;range=1d/json");

            //to replace substrings with user input from the desktop gui
            string selectedRequest = apiList[comboBoxOptions.Text];
            selectedRequest = selectedRequest.Replace("[TICKER]", txtTicker.Text);
            selectedRequest = selectedRequest.Replace("[DAYS]", txtDays.Text);
            selectedRequest = selectedRequest.Replace("[PERIOD]", txtInterval.Text);

            //create RestClient object and set the endpoint w/ user input
            RestClient rClient = new RestClient();
            rClient.endPoint = selectedRequest;

            //make the request to the API and retrieve response
            HttpWebResponse response = (HttpWebResponse)rClient.makeRequest();

            //write to file after retrieving response from API
            if (response.StatusCode == HttpStatusCode.OK)
            {
                debugOutPut("Http request to " + selectedRequest + ": " + response.StatusCode.ToString());
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
                string ep = apiList[comboBoxOptions.Text];
                ep = ep.Replace("[TICKER]", txtTicker.Text);
                ep = ep.Replace("[DAYS]", "1");
                ep = ep.Replace("[PERIOD]", txtInterval.Text);

                rClient.endPoint = ep;

                string filePath = txtFilePath.Text + txtFileName.Text;
                int interval = 0, i = 0;
                Int32.TryParse(txtInterval.Text, out interval);
                list.Add(new autoWriter(rClient, filePath, interval));
                list[i].updateFilePeriodically();
                i++;
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
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "Select a folder where the *.txt file will be saved";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtFilePath.Text = fbd.SelectedPath + "\\";


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
    }
}
