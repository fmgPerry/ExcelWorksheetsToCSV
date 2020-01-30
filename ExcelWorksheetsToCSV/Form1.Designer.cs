namespace ExcelWorksheetsToCSV
{
    partial class Form1
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
            this.labelSaveFolder = new System.Windows.Forms.Label();
            this.buttonSaveLocation = new System.Windows.Forms.Button();
            this.buttonReadExcel = new System.Windows.Forms.Button();
            this.labelFVRCRulesFilename = new System.Windows.Forms.Label();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.openFileDialogFVRCRules = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogSaveFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // labelSaveFolder
            // 
            this.labelSaveFolder.AutoSize = true;
            this.labelSaveFolder.Location = new System.Drawing.Point(168, 46);
            this.labelSaveFolder.Name = "labelSaveFolder";
            this.labelSaveFolder.Size = new System.Drawing.Size(70, 13);
            this.labelSaveFolder.TabIndex = 9;
            this.labelSaveFolder.Text = "Save Folder: ";
            // 
            // buttonSaveLocation
            // 
            this.buttonSaveLocation.Location = new System.Drawing.Point(12, 41);
            this.buttonSaveLocation.Name = "buttonSaveLocation";
            this.buttonSaveLocation.Size = new System.Drawing.Size(150, 23);
            this.buttonSaveLocation.TabIndex = 8;
            this.buttonSaveLocation.Text = "Choose Save Folder";
            this.buttonSaveLocation.UseVisualStyleBackColor = true;
            this.buttonSaveLocation.Click += new System.EventHandler(this.buttonSaveLocation_Click);
            // 
            // buttonReadExcel
            // 
            this.buttonReadExcel.Location = new System.Drawing.Point(12, 80);
            this.buttonReadExcel.Name = "buttonReadExcel";
            this.buttonReadExcel.Size = new System.Drawing.Size(150, 23);
            this.buttonReadExcel.TabIndex = 7;
            this.buttonReadExcel.Text = "Process Excel File";
            this.buttonReadExcel.UseVisualStyleBackColor = true;
            this.buttonReadExcel.Click += new System.EventHandler(this.buttonReadExcel_Click);
            // 
            // labelFVRCRulesFilename
            // 
            this.labelFVRCRulesFilename.AutoSize = true;
            this.labelFVRCRulesFilename.Location = new System.Drawing.Point(168, 17);
            this.labelFVRCRulesFilename.Name = "labelFVRCRulesFilename";
            this.labelFVRCRulesFilename.Size = new System.Drawing.Size(71, 13);
            this.labelFVRCRulesFilename.TabIndex = 6;
            this.labelFVRCRulesFilename.Text = "FVRC Rules: ";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(150, 23);
            this.buttonOpenFile.TabIndex = 5;
            this.buttonOpenFile.Text = "Choose File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // openFileDialogFVRCRules
            // 
            this.openFileDialogFVRCRules.FileName = "openFileDialog1";
            this.openFileDialogFVRCRules.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogFVRCRules_FileOk);
            // 
            // folderBrowserDialogSaveFolder
            // 
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 129);
            this.Controls.Add(this.labelSaveFolder);
            this.Controls.Add(this.buttonSaveLocation);
            this.Controls.Add(this.buttonReadExcel);
            this.Controls.Add(this.labelFVRCRulesFilename);
            this.Controls.Add(this.buttonOpenFile);
            this.Name = "Form1";
            this.Text = "Excel Worksheets to CSV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSaveFolder;
        private System.Windows.Forms.Button buttonSaveLocation;
        private System.Windows.Forms.Button buttonReadExcel;
        private System.Windows.Forms.Label labelFVRCRulesFilename;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogFVRCRules;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSaveFolder;
    }
}

