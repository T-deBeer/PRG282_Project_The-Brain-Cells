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
        List<Composite> composites = new List<Composite>();
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
            lbxToAdd.SelectedIndex = -1;
            students = dh.GetStudents();
            modules = dh.GetModules();
            composites = new List<Composite>();

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
                    txtImage.Text = student.StudentImage;
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

        private void lbxToAdd_SelectedIndexChanged(object sender)
        {
            string StringToSplit = lbxToAdd.SelectedItem.ToString();
            string[] SplitString = StringToSplit.Split(' ');
            string ModuleCodeToAdd = SplitString[0];

            Composite Comp = new Composite();
            Comp.StudentNumber = Convert.ToInt32(cmbNumSelect.SelectedItem);
            Comp.ModuleCode = ModuleCodeToAdd;

            composites.Add(Comp);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MetroSetMessageBox.Show(this, "Are you sure you want to update this student?", "ARE YOU SURE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                string StudentNumberToUpdate = cmbNumSelect.SelectedItem.ToString();
                string StudentNameToUpdate = txtStudName.Text;
                string StudentSurnameToUpdate = txtStudSurname.Text;
                string StudentPhoneToUpdate = txtStudPhone.Text;
                string StudentDOBToUpdate = DateStudDOB.Text;
                string StudentGenderToUpdate = cmbGender.SelectedItem.ToString();
                string StudentAdressToUpdate = txtAddress.Text;
                string StudentImageToUpdate = txtImage.Text;

                Student student = new Student();
                student.StudentNumber = Convert.ToInt32(StudentNumberToUpdate);
                student.StudentName = StudentNameToUpdate;
                student.StudentSurname = StudentSurnameToUpdate;
                student.StudentPhone = StudentPhoneToUpdate;
                student.StudentGender = StudentGenderToUpdate;
                student.StudentDOB = DateTime.ParseExact(StudentDOBToUpdate,"dd/MM/yyyy",null);
                student.StudentImage = StudentImageToUpdate;
                student.StudentAddress = StudentAdressToUpdate;

                dh.UpdateStudent(StudentNumberToUpdate,student,composites);
                LoadStudentInfo(Convert.ToInt32(cmbNumSelect.SelectedItem));
            }
        }
    }
}
