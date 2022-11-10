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
        List<Student> students = new List<Student>();
        List<int> studentNumber = new List<int>();
        List<Module> modules = new List<Module>();
        List<Module> StudentModuleList = new List<Module>();
        public UpdateStudent()
        {
            InitializeComponent();
            students = dh.GetStudents();
            modules = dh.GetModules();
            lbxToAdd.Items.Clear();
            lbxCurrent.Items.Clear();

            foreach (var student in students)
            {
                studentNumber.Add(student.StudentNumber);
            }
            cmbNumSelect.DataSource = studentNumber;
            LoadStudentInfo(Convert.ToInt32(cmbNumSelect.SelectedItem));
        }
        private void LoadStudentInfo(int StudentNum)
        {
            lbxToAdd.Items.Clear();
            lbxCurrent.Items.Clear();
            StudentModuleList = dh.GetStudentModules(StudentNum);
            foreach (var mod in modules)
            {
                lbxToAdd.Items.Add(mod.ModuleCode + " " + mod.ModuleName);
            }
            foreach (var StudMod in StudentModuleList)
            {
                lbxCurrent.Items.Add(StudMod.ModuleCode + " " + StudMod.ModuleName);
            }
            foreach (var student in students)
            {
                if (student.StudentNumber == StudentNum)
                {
                    txtStudName.Text = student.StudentName;
                    txtStudSurname.Text = student.StudentSurname;
                    txtStudPhone.Text = student.StudentPhone;
                    string formattedDate = student.StudentDOB.ToString("dd/MM/yyyy");
                    DateStudDOB.Text = formattedDate;
                    cmbGender.SelectedItem = student.StudentGender;
                    txtAddress.Text = student.StudentAddress;
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
            LoadStudentInfo(Convert.ToInt32(cmbNumSelect.SelectedItem));
        }
    }
}
