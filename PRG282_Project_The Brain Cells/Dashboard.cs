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
    

    public partial class Dashboard : MetroSetForm
    {
           DataBaseHandler DH = new DataBaseHandler();
      

        List<string> tables = new List<string>();
        /*List<Module> modules = new List<Module>();*/
       /* List<Student> students = new List<Student>();*/
       /* List<Composite> composite = new List<Composite>();*/
        /*List<Credential> creds = new List<Credential>();*/

        public Dashboard()
        {
            InitializeComponent();

            tables = DH.GetTables();
        
            DataSet data = new DataSet();
            DataTable dt = new DataTable();
            /*
            modules = dh.GetModules();
            students = dh.GetStudents();
            composite = dh.GetComposite();*/
            data = DH.GetCreds();
            dt = data.Tables[0];
            cmbTableSelect.DataSource = tables;
            LoadDataView(cmbTableSelect.SelectedItem.ToString());
        }

        public void LoadDataView(string tableName)
        {

            DataSet data = new DataSet();
            DataTable dt = new DataTable();

            if (tableName == "ModuleTable")
            {
              
                dgvDataBaseView.DataSource = null;
                data = DH.GetModules();
                dt = data.Tables[0];
                dgvDataBaseView.DataSource = dt;

                btnAdd.Enabled = true;
                btnRemove.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else if (tableName == "StudentTable")
            {
                dgvDataBaseView.DataSource = null;
                data = DH.GetStudents();
                dt = data.Tables[0];

                btnAdd.Enabled = true;
                btnRemove.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else if (tableName == "CompositeTable")
            {
                dgvDataBaseView.DataSource = null;
                data = DH.GetComposite();
                dt = data.Tables[0];

                btnAdd.Enabled = false;
                btnRemove.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else if (tableName == "CredentialTable")
            {
                dgvDataBaseView.DataSource = null;
                data = DH.GetCreds();
                dt = data.Tables[0];
             

                btnAdd.Enabled = true;
                btnRemove.Enabled = true;
                btnUpdate.Enabled = false;
            }
            dgvDataBaseView.DataSource = dt;
        }

        private void cmbTableSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataView(cmbTableSelect.SelectedItem.ToString());
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int selectedRow = dgvDataBaseView.CurrentCell.RowIndex;
            if (selectedRow > 0)
            {
                dgvDataBaseView.Rows[selectedRow].Selected = false;
                dgvDataBaseView.Rows[selectedRow - 1].Selected = true;
                dgvDataBaseView.CurrentCell = dgvDataBaseView[0, selectedRow - 1];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int selectedRow = dgvDataBaseView.CurrentCell.RowIndex;
            if (selectedRow < dgvDataBaseView.Rows.Count - 1)
            {
                dgvDataBaseView.Rows[selectedRow].Selected = false;
                dgvDataBaseView.Rows[selectedRow + 1].Selected = true;
                dgvDataBaseView.CurrentCell = dgvDataBaseView[0, selectedRow + 1];
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tableName = cmbTableSelect.SelectedItem.ToString();

            if (tableName == "ModuleTable")
            {
                AddModule addModule = new AddModule();
                addModule.ShowDialog();
                this.Hide();
            }
            else if (tableName == "StudentTable")
            {
                AddStudent addStudent = new AddStudent();
                addStudent.ShowDialog();
                this.Hide();
            }
            else if (tableName == "CredentialTable")
            {
                AddCredentials addCredentials = new AddCredentials();
                addCredentials.ShowDialog();
                this.Hide();
            }
        }

        private void dgvDataBaseView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
            if (dgvDataBaseView.Columns[0].Name.ToString() == "Username")
            {
                if (e.ColumnIndex == 1 && e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string tableName = cmbTableSelect.SelectedItem.ToString();
            if (tableName == "ModuleTable")
            {
                Update update = new Update();
                update.ShowDialog();
                this.Hide();
            }
            else if (tableName == "StudentTable")
            {
                UpdateStudent updateStudent = new UpdateStudent();
                updateStudent.ShowDialog();
                this.Hide();
            }
        }
    }
}
