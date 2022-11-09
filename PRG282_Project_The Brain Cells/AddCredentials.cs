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
    public partial class AddCredentials : MetroSetForm
    {
        DataBaseHandler dh = new DataBaseHandler();

        List<Credential> creds = new List<Credential>();
        List<Credential> currentCreds = new List<Credential>();

        public AddCredentials()
        {
            InitializeComponent();

            currentCreds = dh.GetCreds();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void ClearFields()
        {
            txtConfirmPassword.Text = null;
            txtPassword.Text = null;
            txtUsername.Text = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPassword.Text && txtPassword.Text != " " || txtPassword.Text != "" 
                && txtUsername.Text != " " || txtUsername.Text != "")
            {
                if (!exists())
                {
                    creds.Add(new Credential { Username = txtUsername.Text, Password = txtPassword.Text });
                    lbxToAdd.Items.Add(txtUsername.Text);
                }
                else
                {
                    MetroSetMessageBox.Show(this, "Username is already in use.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MetroSetMessageBox.Show(this, "Some of your inputs were incorrect.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool exists()
        {
            foreach (var credential in currentCreds)
            {
                if (credential.Username == txtUsername.Text)
                {
                    return false;
                }
            }
            return true;
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

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (creds.Count >= 1)
            {
                foreach (var cred in creds)
                {
                    dh.AddCredential(cred);
                }
            }
            else
            {
                MetroSetMessageBox.Show(this, "Enter the details for new login credentials before writing to database."
                    , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
