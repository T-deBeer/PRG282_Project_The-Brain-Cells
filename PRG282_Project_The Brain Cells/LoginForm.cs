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
            DataHandler handler = new DataHandler();
            handler.WriteLogin();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("You Have logged in successfully", "Login Successfull");
                Menu mainMenu = new Menu();
                mainMenu.Show();
                this.Hide();
                DataHandler data = new DataHandler();
                data.LogData = data.GetLog();
                data.LogData.Add("Login from: " + UsernameToCheck);
            }
            /**
            DataBaseHandler dh = new DataBaseHandler();
            if (dh.CheckCredential(txtUsername.Text,txtPassword.Text))
            {
                Dashboard form = new Dashboard();
                form.ShowDialog();
                this.Hide();
            }
            else
            {
                MetroSetMessageBox.Show(this,"Your username or password is incorrect.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtPassword.Text = null;
                txtUsername.Text = null;
            }
            **/
        }

        private void llblCreateAcconunt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm form = new SignUpForm();
            form.Show();
            this.Hide();
        }
    }
}
