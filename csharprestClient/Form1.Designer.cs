namespace csharprestClient
{
    partial class GoogleApiCaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabActiveFiles = new System.Windows.Forms.TabPage();
            this.tabCreatFile = new System.Windows.Forms.TabPage();
            this.btnWriteToFile = new System.Windows.Forms.Button();
            this.comboBoxOptions = new System.Windows.Forms.ComboBox();
            this.txtTicker = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tabCreateFile = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabCreatFile.SuspendLayout();
            this.tabCreateFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabActiveFiles
            // 
            this.tabActiveFiles.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabActiveFiles.Location = new System.Drawing.Point(4, 25);
            this.tabActiveFiles.Margin = new System.Windows.Forms.Padding(2);
            this.tabActiveFiles.Name = "tabActiveFiles";
            this.tabActiveFiles.Padding = new System.Windows.Forms.Padding(2);
            this.tabActiveFiles.Size = new System.Drawing.Size(991, 546);
            this.tabActiveFiles.TabIndex = 1;
            this.tabActiveFiles.Text = "Active Files";
            this.tabActiveFiles.UseVisualStyleBackColor = true;
            // 
            // tabCreatFile
            // 
            this.tabCreatFile.Controls.Add(this.label8);
            this.tabCreatFile.Controls.Add(this.rbNo);
            this.tabCreatFile.Controls.Add(this.rbYes);
            this.tabCreatFile.Controls.Add(this.txtFileName);
            this.tabCreatFile.Controls.Add(this.txtInterval);
            this.tabCreatFile.Controls.Add(this.txtResponse);
            this.tabCreatFile.Controls.Add(this.txtDays);
            this.tabCreatFile.Controls.Add(this.txtFilePath);
            this.tabCreatFile.Controls.Add(this.txtTicker);
            this.tabCreatFile.Controls.Add(this.btnSelectFolder);
            this.tabCreatFile.Controls.Add(this.label3);
            this.tabCreatFile.Controls.Add(this.label4);
            this.tabCreatFile.Controls.Add(this.label5);
            this.tabCreatFile.Controls.Add(this.label7);
            this.tabCreatFile.Controls.Add(this.label6);
            this.tabCreatFile.Controls.Add(this.label1);
            this.tabCreatFile.Controls.Add(this.label2);
            this.tabCreatFile.Controls.Add(this.comboBoxOptions);
            this.tabCreatFile.Controls.Add(this.btnWriteToFile);
            this.tabCreatFile.Location = new System.Drawing.Point(4, 25);
            this.tabCreatFile.Margin = new System.Windows.Forms.Padding(2);
            this.tabCreatFile.Name = "tabCreatFile";
            this.tabCreatFile.Padding = new System.Windows.Forms.Padding(2);
            this.tabCreatFile.Size = new System.Drawing.Size(991, 546);
            this.tabCreatFile.TabIndex = 0;
            this.tabCreatFile.Text = "Create File";
            this.tabCreatFile.UseVisualStyleBackColor = true;
            // 
            // btnWriteToFile
            // 
            this.btnWriteToFile.Location = new System.Drawing.Point(356, 169);
            this.btnWriteToFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnWriteToFile.Name = "btnWriteToFile";
            this.btnWriteToFile.Size = new System.Drawing.Size(239, 40);
            this.btnWriteToFile.TabIndex = 2;
            this.btnWriteToFile.Text = "Write To File";
            this.btnWriteToFile.UseVisualStyleBackColor = true;
            this.btnWriteToFile.Click += new System.EventHandler(this.cmdGO_Click);
            // 
            // comboBoxOptions
            // 
            this.comboBoxOptions.FormattingEnabled = true;
            this.comboBoxOptions.Items.AddRange(new object[] {
            "Google Finance",
            "Yahoo Finance"});
            this.comboBoxOptions.Location = new System.Drawing.Point(120, 23);
            this.comboBoxOptions.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxOptions.Name = "comboBoxOptions";
            this.comboBoxOptions.Size = new System.Drawing.Size(269, 24);
            this.comboBoxOptions.TabIndex = 12;
            // 
            // txtTicker
            // 
            this.txtTicker.Location = new System.Drawing.Point(685, 101);
            this.txtTicker.Name = "txtTicker";
            this.txtTicker.Size = new System.Drawing.Size(258, 22);
            this.txtTicker.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Log:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "API:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(120, 98);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(434, 22);
            this.txtFilePath.TabIndex = 14;
            this.txtFilePath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(685, 62);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(258, 22);
            this.txtDays.TabIndex = 8;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(4, 242);
            this.txtResponse.Margin = new System.Windows.Forms.Padding(2);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(981, 302);
            this.txtResponse.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "File Name:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "File path:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ticker:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Days:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(685, 25);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(258, 22);
            this.txtInterval.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interval (seconds):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(120, 169);
            this.btnSelectFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(223, 40);
            this.btnSelectFolder.TabIndex = 16;
            this.btnSelectFolder.Text = "Select Folder\r\n";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(120, 59);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(269, 22);
            this.txtFileName.TabIndex = 17;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(120, 127);
            this.rbYes.Margin = new System.Windows.Forms.Padding(2);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(53, 21);
            this.rbYes.TabIndex = 18;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Checked = true;
            this.rbNo.Location = new System.Drawing.Point(177, 129);
            this.rbNo.Margin = new System.Windows.Forms.Padding(2);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(47, 21);
            this.rbNo.TabIndex = 19;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 129);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Auto write to file:";
            // 
            // tabCreateFile
            // 
            this.tabCreateFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCreateFile.Controls.Add(this.tabCreatFile);
            this.tabCreateFile.Controls.Add(this.tabActiveFiles);
            this.tabCreateFile.Location = new System.Drawing.Point(11, 2);
            this.tabCreateFile.Margin = new System.Windows.Forms.Padding(2);
            this.tabCreateFile.Name = "tabCreateFile";
            this.tabCreateFile.SelectedIndex = 0;
            this.tabCreateFile.Size = new System.Drawing.Size(999, 575);
            this.tabCreateFile.TabIndex = 17;
            // 
            // GoogleApiCaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 584);
            this.Controls.Add(this.tabCreateFile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GoogleApiCaller";
            this.Text = "C# REST Client";
            this.Load += new System.EventHandler(this.GoogleApiCaller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabCreatFile.ResumeLayout(false);
            this.tabCreatFile.PerformLayout();
            this.tabCreateFile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.TabPage tabActiveFiles;
        private System.Windows.Forms.TabPage tabCreatFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtTicker;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOptions;
        private System.Windows.Forms.Button btnWriteToFile;
        private System.Windows.Forms.TabControl tabCreateFile;
    }
}

