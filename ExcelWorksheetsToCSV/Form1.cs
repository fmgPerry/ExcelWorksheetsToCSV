using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelWorksheetsToCSV
{
    public partial class Form1 : Form
    {
        private static string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        private static string FVRCRulesLabel = "FVRC Rules:";
        private static string saveFolderLabel = "Save Folder:";
        private static string fvrcFilename = "";
        private static string saveFolder = "";
        public Form1()
        {
            InitializeComponent();
            labelFVRCRulesFilename.Text = $@"{FVRCRulesLabel}";
            labelSaveFolder.Text = $@"{saveFolderLabel}";
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogFVRCRules.InitialDirectory = desktopFolder;
            openFileDialogFVRCRules.ShowDialog();
        }

        private void buttonSaveLocation_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogSaveFolder.ShowDialog() == DialogResult.OK)
            {
                saveFolder = folderBrowserDialogSaveFolder.SelectedPath;
                labelSaveFolder.Text = $@"{saveFolderLabel} {saveFolder}";
            }
        }

        private void openFileDialogFVRCRules_FileOk(object sender, CancelEventArgs e)
        {
            fvrcFilename = openFileDialogFVRCRules.FileName;
            labelFVRCRulesFilename.Text = $@"{FVRCRulesLabel} {fvrcFilename}";
        }
        private void buttonReadExcel_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Excel.Application oXL;
            Excel._Workbook oWB;

            //Start Excel and get Application object
            oXL = new Excel.Application();
            oXL.Visible = true;
            oXL.DisplayAlerts = false;

            // Open Excel File
            oWB = oXL.Workbooks.Open(fvrcFilename,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing);

            // go through all worksheets and save each one as CSV
            foreach (Excel.Worksheet worksheet in oWB.Worksheets)
            {
                worksheet.Select(Type.Missing);
                oWB.SaveAs($@"{saveFolder}/{worksheet.Name}.csv", Excel.XlFileFormat.xlCSV, Excel.XlSaveAsAccessMode.xlNoChange);
            }

            oWB.Close(0);
            oXL.Quit();

            Cursor.Current = Cursors.Default;
            MessageBox.Show("Done. Opening Save Folder");

            // Open Save Folder
            Process.Start(saveFolder);
        }

    }
}
