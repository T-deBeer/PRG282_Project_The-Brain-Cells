using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
