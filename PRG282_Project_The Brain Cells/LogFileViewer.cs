using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            try
            {
                dataHandler.WriteLogFile();
            }
            catch (Exception)
            {

                throw;
            }
            for (int i = 0; i < dataHandler.LogData.Count; i++)
            {
                mrtbLogFile.Text += dataHandler.LogData[i];
            }
            
            
            
        }
    }
}
