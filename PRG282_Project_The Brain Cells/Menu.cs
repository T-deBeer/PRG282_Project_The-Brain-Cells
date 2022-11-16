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
    public partial class Menu : MetroSetForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnLogFile_Click(object sender, EventArgs e)
        {
            //Opens the log file viewer
            LogFileViewer log = new LogFileViewer();
            log.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //Opens the dashboard
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //opens the add student form
            AddStudent student = new AddStudent();
            student.Show();
            this.Hide();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            //opens the update student form
            UpdateStudent student = new UpdateStudent();
            student.Show();
            this.Hide();
        }

        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            //opens the signup form
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            //opens the add module form
            AddModule module = new AddModule();
            module.Show();
            this.Hide();
        }

        private void btnUpdateModule_Click(object sender, EventArgs e)
        {
            //opens the update module form
            UpdateModule module = new UpdateModule();
            module.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exits the application
            Application.Exit();
        }
    }
}
