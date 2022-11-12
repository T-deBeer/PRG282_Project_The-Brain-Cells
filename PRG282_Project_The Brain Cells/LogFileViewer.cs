using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_The_Brain_Cells
{
    public partial class LogFileViewer : MetroSetForm
    {
        public LogFileViewer()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           Menu mainMenu= new Menu();
            mainMenu.Show();
            this.Hide();
        }

        private void LogFileViewer_Load(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();
            string LogFilePath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\LogFile.txt";

            string[] LastLines = File.ReadAllLines(LogFilePath);

            for (int i = LastLines.Length-1; i > LastLines.Length - 100; i--)
            {
                if (i >= 0)
                {
                    mrtbLogFile.AppendText(LastLines[i] + "\n");
                }
                else
                {
                    break;
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string LogFilePath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\LogFile.txt";
            string bodyText = "";

            DataHandler data = new DataHandler();
            List<string> lines = data.GetLog();

            foreach (var line in lines)
            {
                bodyText += line + "%20%3A%0D%0A";
            }

            System.Diagnostics.Process.Start($@"mailto:?subject=Log File Transcript from NeuroTix System&body={bodyText}");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    DataHandler data = new DataHandler();
                    List<string> lines = data.GetLog();

                    string textFilePath = fbd.SelectedPath+@"\LogFileCopy.txt";

                    if (File.Exists(textFilePath))
                    {
                        File.Delete(textFilePath);
                    }

                    try
                    {
                        using (TextWriter writer = new StreamWriter(textFilePath))
                        {
                            foreach (var line in lines)
                            {
                                writer.WriteLine(line);
                            }
                        }
                        MessageBox.Show($"Copy has been created @{textFilePath}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
