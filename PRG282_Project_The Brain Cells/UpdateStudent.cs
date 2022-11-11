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
    public partial class UpdateStudent : MetroSetForm
    {
        DataBaseHandler dh = new DataBaseHandler();

        List<string> studNumbers = new List<string>();
  
        List<Student> allStudents = new List<Student>();
        List<Module> allModules = new List<Module>();

        List<Composite> allComposites = new List<Composite>();
        List<Composite> compositesToAdd = new List<Composite>();
        List<Composite> compositesToRemove = new List<Composite>();
        List<string> studModules = new List<string>();
        public UpdateStudent()
        {
            InitializeComponent();

            allStudents = dh.GetStudents();
            allModules = dh.GetModules();
            allComposites = dh.GetComposite();

            foreach (var stud in allStudents)
            {
                studNumbers.Add(stud.StudentNumber.ToString());
            }

            cmbNumSelect.DataSource = studNumbers;
            LoadStudentInfo(int.Parse(cmbNumSelect.SelectedItem.ToString()));
        }
        private void LoadStudentInfo(int StudentNum)
        {
            lbxCurrent.Items.Clear();
            lbxCurrent.SelectedIndex = -1;

            lbxToAdd.Items.Clear();
            lbxToAdd.SelectedIndex= -1;

            allStudents = dh.GetStudents();
            allModules = dh.GetModules();
            allComposites = dh.GetComposite();

            foreach (var stud in allStudents)
            {
                if (stud.StudentNumber == StudentNum)
                {
                    txtStudName.Text = stud.StudentName;
                    txtStudSurname.Text = stud.StudentSurname;
                    txtStudPhone.Text = stud.StudentPhone;
                    DateStudDOB.Text = stud.StudentDOB.ToString("dd/MM/yyyy"); ;
                    txtImage.Text = stud.StudentImage;
                    cmbGender.SelectedItem = stud.StudentGender;
                    txtAddress.Text = stud.StudentAddress;
                }
            }

            foreach (var comp in allComposites)
            {
                if (comp.StudentNumber == StudentNum)
                {
                    studModules.Add(comp.ModuleCode);
                }
            }

            foreach (var comp in compositesToAdd)
            {
                if (comp.StudentNumber == StudentNum)
                {
                    studModules.Add(comp.ModuleCode);
                }
            }

            foreach (var comp in compositesToRemove)
            {
                if (studModules.Contains(comp.ModuleCode))
                {
                    studModules.Remove(comp.ModuleCode);
                }
                if (compositesToAdd.Contains(comp))
                {
                    compositesToAdd.Remove(comp);
                }
            }

            foreach (var mod in allModules)
            {
                if (studModules.Contains(mod.ModuleCode))
                {
                    lbxCurrent.Items.Add($"{mod.ModuleCode} {mod.ModuleName}");
                }
                else
                {
                    lbxToAdd.Items.Add($"{mod.ModuleCode} {mod.ModuleName}");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void cmbNumSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            compositesToAdd.Clear();
            compositesToRemove.Clear();
            studModules.Clear();
            LoadStudentInfo(Convert.ToInt32(cmbNumSelect.SelectedItem));
        }

        private void lbxToAdd_SelectedIndexChanged(object sender)
        {
            string selectedModCode = lbxToAdd.SelectedItem.ToString().Split(' ')[0];

            foreach (var mod in allModules)
            {
                if (mod.ModuleCode == selectedModCode)
                {
                    Composite composite = new Composite();
                    composite.ModuleCode = selectedModCode;
                    composite.StudentNumber = int.Parse(cmbNumSelect.SelectedItem.ToString());

                    compositesToAdd.Add(composite);
                }
            }
            LoadStudentInfo(int.Parse(cmbNumSelect.SelectedItem.ToString()));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MetroSetMessageBox.Show(this, "Are you sure you want to update this student's information?", "ARE YOU SURE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Student student = new Student();

                student.StudentNumber = int.Parse(cmbNumSelect.SelectedItem.ToString());
                student.StudentName = txtStudName.Text;
                student.StudentSurname = txtStudSurname.Text;
                student.StudentPhone = txtStudPhone.Text;
                student.StudentGender = cmbGender.SelectedItem.ToString();
                student.StudentDOB = DateTime.ParseExact(DateStudDOB.Text, "dd/MM/yyyy", null);
                student.StudentImage = txtImage.Text;
                student.StudentAddress = txtAddress.Text;

                dh.UpdateStudent(student);

                foreach (var comp in allComposites.Where(x => x.StudentNumber == int.Parse(cmbNumSelect.SelectedItem.ToString())))
                {
                    if (!studModules.Contains(comp.ModuleCode))
                    {
                        dh.RemoveComposite(comp);
                    }
                }
                foreach (var code in studModules.Distinct().ToList())
                {
                    Composite comp = new Composite();
                    comp.ModuleCode = code;
                    comp.StudentNumber = int.Parse(cmbNumSelect.SelectedItem.ToString());

                    dh.InsertComposite(comp);
                }

                compositesToAdd.Clear();
                compositesToRemove.Clear();
                studModules.Clear();
                LoadStudentInfo(int.Parse(cmbNumSelect.SelectedItem.ToString()));
            }
        }

        private void lbxCurrent_SelectedIndexChanged(object sender)
        {
            string selectedModCode = lbxCurrent.SelectedItem.ToString().Split(' ')[0];

            foreach (var mod in allModules)
            {
                if (mod.ModuleCode == selectedModCode)
                {
                    Composite composite = new Composite();
                    composite.ModuleCode = selectedModCode;
                    composite.StudentNumber = int.Parse(cmbNumSelect.SelectedItem.ToString());

                    compositesToRemove.Add(composite);
                }
            }
            LoadStudentInfo(int.Parse(cmbNumSelect.SelectedItem.ToString()));
        }
    }
}
