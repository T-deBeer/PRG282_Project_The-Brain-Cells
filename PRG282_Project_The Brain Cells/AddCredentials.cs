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

        /*List<Credential> creds = new List<Credential>();*/
        /*List<Credential> currentCreds = new List<Credential>();*/

        public AddCredentials()
        {
            InitializeComponent();

       
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
            DataSet data = new DataSet();
             data =   dh.GetCreds();
            DataTable dt = new DataTable();
            dt = data.Tables[0];
            DataHandler handler = new DataHandler();
            if (txtPassword.Text == txtConfirmPassword.Text && !String.IsNullOrWhiteSpace(txtPassword.Text) 
                && !String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                if (!exists(handler.CredentialsToList(dt)))
                {
                    Credential newCred = new Credential(txtUsername.Text, txtPassword.Text);
                   
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

        private bool exists(List<Credential> currentCreds)
        {
           
            string username;
            string password;
            foreach (var cred in currentCreds)
            {

                
                username = cred.Username;
                password = cred.Password;
              
                if (  dh.CheckCredential(username, password))
                {
                  return true;
                }
            }
                 return false;
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
          /*  if (creds.Count >= 1)
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
            }*/
        }
    }
}
