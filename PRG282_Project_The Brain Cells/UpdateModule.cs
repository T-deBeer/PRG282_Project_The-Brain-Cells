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
    public partial class Update : MetroSetForm
    {
        DataBaseHandler dh = new DataBaseHandler();

       
       // List<string> moduleCodes = new List<string>();
        public Update()
        {
            InitializeComponent();
            DataSet modules = new DataSet();
           List<Module> modulesList = new List<Module>();
            modules = dh.GetModules();
            DataTable table = new DataTable();
            table = modules.Tables[0];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                modulesList.Add(new Module(table.Rows[i]["Module_Code"].ToString(), table.Rows[i]["Module_Name"].ToString(),
                                                                table.Rows[i]["Module_Description"].ToString(), table.Rows[i]["Module_Link"].ToString()));
            }
            /*foreach (var mod in modules)
            {
                moduleCodes.Add(mod.ModuleCode);
            }*/

            cmbCodeSelect.DataSource = modulesList;
            LoadInformation(cmbCodeSelect.SelectedItem.ToString());
        }

        private void LoadInformation(string code)
        {
            DataSet modules = dh.GetModules();
            DataTable dataTable = modules.Tables[0];
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i]["Module_Code"].ToString() == code)
                {
                    txtModuleName.Text = dataTable.Rows[i]["Module_Name"].ToString();
                    txtResource.Text = dataTable.Rows[i]["Module_Resource"].ToString(); 
                    txtModuleDescription.Text = dataTable.Rows[i]["Module_Description"].ToString(); 
                }
            }
          /*  foreach (var mod in modules)
            {
                if (mod.ModuleCode == code)
                {
                    txtModuleName.Text = mod.ModuleName;
                    txtResource.Text = mod.ModuleResource;
                    txtModuleDescription.Text = mod.ModuleDescription;
                }
            }*/
        }

        private void cmbCodeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInformation(cmbCodeSelect.SelectedItem.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearFields();
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void clearFields()
        {
            txtModuleName.Text = null;
            txtResource.Text = null;
            txtModuleDescription.Text = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MetroSetMessageBox.Show(this, "Are you sure you want to update this module.", "ARE YOU SURE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Module mod = new Module();
                mod.ModuleCode = cmbCodeSelect.SelectedItem.ToString();
                mod.ModuleDescription = txtModuleDescription.Text;
                mod.ModuleName = txtModuleName.Text;
                mod.ModuleResource = txtResource.Text;
            }
        }
    }
}
