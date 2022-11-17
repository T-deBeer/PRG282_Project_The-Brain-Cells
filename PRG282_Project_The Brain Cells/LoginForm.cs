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
    public partial class LoginForm : MetroSetForm
    {
        public LoginForm()
        {
            InitializeComponent();
            //Calls a method to write the login details to a text file from the database
            DataHandler handler = new DataHandler();
            handler.WriteLogin();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the application
            if (DialogResult.Yes == MetroSetMessageBox.Show(this, "Are you sure you want to quit the application?", "ARE YOU SURE?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                Application.Exit();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //Shows the hidden text in the password text box
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //validates the login and and opens the main menu
            string UsernameToCheck = txtUsername.Text;
            string PasswordToCheck = txtPassword.Text;
            bool Login = false;
            DataHandler dataHandler = new DataHandler();
            string[] TextLines = dataHandler.ReadTextFile();

            for (int i = 0; i < TextLines.Length; i++)
            {
                string[] SplitLines = TextLines[i].Split(',');
                if (SplitLines[0] == UsernameToCheck && SplitLines[1] == PasswordToCheck)
                {
                    Login = true;
                }
            }
            if (Login == false)
            {
                MessageBox.Show("Your password or username did not match", "Login Failed");
            }
            else if (Login == true)
            {
                DataHandler data = new DataHandler();
                data.AddToLogFile("Login from: " + UsernameToCheck);
                MessageBox.Show("You Have logged in successfully", "Login Successfull");
                Menu mainMenu = new Menu();
                mainMenu.Show();
                this.Hide();
                
            }
           
        }

        private void llblCreateAcconunt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Opens the sign up form
            SignUpForm form = new SignUpForm();
            form.Show();
            this.Hide();
        }
    }
}
