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
        DataBaseHandler dh = new DataBaseHandler();

        List<string> tables = new List<string>();
        List<Module> modules = new List<Module>();
        List<Student> students = new List<Student>();
        List<Composite> composite = new List<Composite>();
        List<Credential> creds = new List<Credential>();

        public Dashboard()
        {
            int SortByHold;
            InitializeComponent();

            tables = dh.GetTables();
            modules = dh.GetModules();
            students = dh.GetStudents();
            composite = dh.GetComposite();
            creds = dh.GetCreds();

            cmbTableSelect.DataSource = tables;
            SortByHold = cmbTableSelect.SelectedIndex;

            LoadDataView(cmbTableSelect.SelectedItem.ToString());
            cmbSortByUpdate(SortByHold);
        }

        public void LoadDataView(string tableName)
        {
            if (tableName == "ModuleTable")
            {
                dgvDataBaseView.DataSource = null;
                dgvDataBaseView.DataSource = modules;

                btnAdd.Enabled = true;
                btnRemove.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else if (tableName == "StudentTable")
            {
                dgvDataBaseView.DataSource = null;
                dgvDataBaseView.DataSource = students;

                btnAdd.Enabled = true;
                btnRemove.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else if (tableName == "CompositeTable")
            {
                dgvDataBaseView.DataSource = null;
                dgvDataBaseView.DataSource = composite;

                btnAdd.Enabled = false;
                btnRemove.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else if (tableName == "CredentialTable")
            {
                dgvDataBaseView.DataSource = null;
                dgvDataBaseView.DataSource = creds;

                btnAdd.Enabled = true;
                btnRemove.Enabled = true;
                btnUpdate.Enabled = false;
            }
        }

        private void cmbTableSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadDataView(cmbTableSelect.SelectedItem.ToString());
            cmbSortByUpdate(cmbTableSelect.SelectedIndex);
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
            if (dgvDataBaseView.DataSource == creds)
            {
                if (e.ColumnIndex == 1 && e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
            }
        }



        public void cmbSortByUpdate(int tableSelected)
        {
            List<string> cmbOptions = new List<string>();
            switch (tableSelected)
            {
                case 0:
                    {
                        cmbOptions.Add("Sort by Module Code");
                        cmbOptions.Add("Sort by Module Name");
                        break;
                    }
                case 1:
                    {
                        cmbOptions.Add("Sort by Student Number");
                        cmbOptions.Add("Sort by Module Code");

                        break;
                    }
                case 2:
                    {
                        cmbOptions.Add("Sort by Username");
                        cmbOptions.Add("Unsort");

                        break;
                    }
                case 3:
                    {
                        cmbOptions.Add("Sort by Student Number");
                        cmbOptions.Add("Sort by Student Name");

                        break;
                    }
                default:
                    break;
            }
            cmbSortBy.DataSource = cmbOptions;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string tableName = cmbTableSelect.SelectedItem.ToString();
            if (tableName == "ModuleTable")
            {
                UpdateModule update = new UpdateModule();
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

        private void cmbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
               List<Module> modules = new List<Module>();
                 List<Composite> composite = new List<Composite>();
 List<Credential> creds = new List<Credential>();
        List<Student> students = new List<Student>();
            */
            int tableIndex = cmbTableSelect.SelectedIndex;
            dgvDataBaseView.DataSource = null;

            switch (tableIndex)
            {
                case 0:
                    {
                        if (cmbSortBy.SelectedIndex == 0)
                            modules.Sort((a, b) => a.ModuleCode.CompareTo(b.ModuleCode));
                        else
                            modules.Sort((a, b) => a.ModuleName.CompareTo(b.ModuleName));
                        dgvDataBaseView.DataSource = modules;
                        break;
                    }
                case 1:
                    {
                        if (cmbSortBy.SelectedIndex == 0)
                            composite.Sort((a, b) => a.StudentNumber.CompareTo(b.StudentNumber));

                        else
                            composite.Sort((a, b) => a.ModuleCode.CompareTo(b.ModuleCode));

                        dgvDataBaseView.DataSource = composite;
                        break;
                    }
                case 2:
                    {
                        if (cmbSortBy.SelectedIndex == 0)
                            creds.Sort((a, b) => a.Username.CompareTo(b.Username));
                        else
                            creds.Sort((a, b) => a.Password.CompareTo(b.Password));
                        dgvDataBaseView.DataSource = creds;
                        break;
                    }
                case 3:
                    {
                        if (cmbSortBy.SelectedIndex == 0)
                            students.Sort((a, b) => a.StudentNumber.CompareTo(b.StudentNumber));
                        else
                            students.Sort((a, b) => a.StudentName.CompareTo(b.StudentName));
                        dgvDataBaseView.DataSource = students;
                        break;
                    }




                default:
                    break;
            }
        }

        private void dgvDataBaseView_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
