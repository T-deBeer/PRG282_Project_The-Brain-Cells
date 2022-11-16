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
    public partial class SignUpForm :  MetroSetForm
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void llblGotAnAcconunt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //opens the login form
            LoginForm form= new LoginForm();
            form.Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //Declaration of variables
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            string PasswordConfirm = txtConfirmPassword.Text;
            bool UserExists = false;
            bool TextFieldNotNull = false;

            DataBaseHandler handler = new DataBaseHandler();
            DataHandler dh = new DataHandler();
            //validates the input and creates a user on the database
            string[] TextLines = dh.ReadTextFile();
            if (!String.IsNullOrEmpty(Password) && !String.IsNullOrEmpty(Username) && !String.IsNullOrEmpty(PasswordConfirm))
            {
                TextFieldNotNull = true;
            }
            else if (String.IsNullOrEmpty(Username))
            {
                MessageBox.Show("A username is required");
            }
            else if (String.IsNullOrEmpty(Password))
            {
                MessageBox.Show("A password is required");
            }
            else if (String.IsNullOrEmpty(PasswordConfirm))
            {
                MessageBox.Show("The confirm password is required");
            }

            for (int i = 0; i < TextLines.Length; i++)
            {
                string[] SplitLines = TextLines[i].Split(',');
                if (SplitLines[0] == Username)
                {
                    UserExists = true;
                    MessageBox.Show("Username is allready used");
                    break;
                }
            }

            if (UserExists == false && Password == PasswordConfirm && TextFieldNotNull)
            {
                Credential credential = new Credential
                {
                    Username = Username,
                    Password = Password,
                };
                handler.AddCredential(credential);
                LoginForm form = new LoginForm();
                form.Show();
                this.Hide();
            }
            else if (Password != PasswordConfirm)
            {
                MessageBox.Show("Passwords did not match");
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //shows the hidden text in the password text box
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnConfirmView_Click(object sender, EventArgs e)
        {
            //shows the hidden text in the confirm password text box
            if (txtConfirmPassword.UseSystemPasswordChar)
            {
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //opens the login from
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }
    }
}
