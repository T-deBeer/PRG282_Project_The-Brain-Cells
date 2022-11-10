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
            LoginForm form= new LoginForm();
            form.Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            string PasswordConfirm = txtConfirmPassword.Text;

            DataBaseHandler handler = new DataBaseHandler();
            
            if (Password == PasswordConfirm && !String.IsNullOrEmpty(Password))
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
            else
            {
                MessageBox.Show("Passwords did not match");
            }
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

        private void btnConfirmView_Click(object sender, EventArgs e)
        {
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
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }
    }
}
