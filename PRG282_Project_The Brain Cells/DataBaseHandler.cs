using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_The_Brain_Cells
{
    internal class DataBaseHandler
    {
        public List<Module> GetModules()
        {
            List<Module> modules = new List<Module>();
            DataSet dataSet = new DataSet();

            string DBPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SystemDatabase.mdf";
            string dataSource = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={DBPath};Integrated Security=True";

            SqlConnection con = new SqlConnection(dataSource);

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ModuleTable", con);

            adapter.Fill(dataSet);

            modules = dataSet.Tables[0].AsEnumerable().Select(dataRow => new Module
            {
                ModuleCode = dataRow.Field<string>("Module_Code"),
                ModuleDescription = dataRow.Field<string>("Module_Description"),
                ModuleName = dataRow.Field<string>("Module_Name"),
                ModuleResource = dataRow.Field<string>("Module_Link")
            }).ToList();

            return modules;

        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            DataSet dataSet = new DataSet();

            string DBPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SystemDatabase.mdf";
            string dataSource = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={DBPath};Integrated Security=True";

            SqlConnection con = new SqlConnection(dataSource);

            SqlDataAdapter adapter = adapter = new SqlDataAdapter("SELECT * FROM StudentTable", con);

            adapter.Fill(dataSet);

            students = dataSet.Tables[0].AsEnumerable().Select(dataRow => new Student
            {
                StudentNumber = dataRow.Field<int>("Student_Number"),
                StudentName = dataRow.Field<string>("Student_Name"),
                StudentSurname = dataRow.Field<string>("Student_Surname"),
                StudentImage = dataRow.Field<string>("Student_Image"),
                StudentGender = dataRow.Field<string>("Student_Gender"),
                StudentDOB = dataRow.Field<DateTime>("Student_DOB"),
                StudentPhone = dataRow.Field<string>("Student_Phone"),
                StudentAddress = dataRow.Field<string>("Student_Address")

            }).ToList();

            return students;
        }

        public List<Composite> GetComposite()
        {
            List<Composite> composite = new List<Composite>();
            DataSet dataSet = new DataSet();

            string DBPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SystemDatabase.mdf";
            string dataSource = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={DBPath};Integrated Security=True";

            SqlConnection con = new SqlConnection(dataSource);

            SqlDataAdapter adapter = adapter = new SqlDataAdapter("SELECT * FROM CompositeTable", con);

            adapter.Fill(dataSet);

            composite = dataSet.Tables[0].AsEnumerable().Select(dataRow => new Composite
            {
                StudentNumber = dataRow.Field<int>("Student_Number"),
                ModuleCode = dataRow.Field<string>("Module_Code")
            }).ToList();

            return composite;
        }

        public List<Credential> GetCreds()
        {
            List<Credential> creds = new List<Credential>();
            DataSet dataSet = new DataSet();

            string DBPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SystemDatabase.mdf";
            string dataSource = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={DBPath};Integrated Security=True";

            SqlConnection con = new SqlConnection(dataSource);

            SqlDataAdapter adapter = adapter = new SqlDataAdapter("SELECT * FROM CredentialTable", con);

            adapter.Fill(dataSet);

            creds = dataSet.Tables[0].AsEnumerable().Select(dataRow => new Credential
            {
                Username = dataRow.Field<string>("Username"),
                Password = dataRow.Field<string>("Password")

            }).ToList();

            return creds;
        }

        public bool CheckCredential(string Username, string Password)
        {
            DataSet dataSet = new DataSet();

            string DBPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SystemDatabase.mdf";
            string dataSource = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={DBPath};Integrated Security=True";

            SqlConnection con = new SqlConnection(dataSource);

            SqlDataAdapter adapter = adapter = new SqlDataAdapter("SELECT * FROM CredentialTable", con);

            adapter.Fill(dataSet);

            List<Credential> credentials = dataSet.Tables[0].AsEnumerable().Select(dataRow => new Credential
            {
                Username = dataRow.Field<string>("Username"),
                Password = dataRow.Field<string>("Password")

            }).ToList();

            foreach (var cred in credentials)
            {
                if(cred.Username == Username)
                {
                    if (cred.Password == Password)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public List<string> GetTables()
        {
            List<string> tables = new List<string>();

            string DBPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SystemDatabase.mdf";
            string dataSource = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={DBPath};Integrated Security=True";

            SqlConnection con = new SqlConnection(dataSource);

            try
            {
                con.Open();
                DataTable dt = con.GetSchema("Tables");

                foreach (DataRow row in dt.Rows)
                {
                    tables.Add((string)row[2]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CRITICAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            return tables;
        }

        public void AddCredential(Credential cred)
        {
            string DBPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SystemDatabase.mdf";
            string dataSource = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={DBPath};Integrated Security=True";

            SqlConnection con = new SqlConnection(dataSource);

            try
            {
                con.Open();
                var sql = "INSERT INTO CredentialTable (Username, Password) VALUES (@Username, @Password)";

                using(var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Username",cred.Username);
                    cmd.Parameters.AddWithValue("@Password",cred.Password);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CRITICAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        public void AddModule(Module mod)
        {
            string DBPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SystemDatabase.mdf";
            string dataSource = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={DBPath};Integrated Security=True";

            SqlConnection con = new SqlConnection(dataSource);

            try
            {
                con.Open();
                var sql = "INSERT INTO ModuleTable (Module_Code, Module_Name, Module_Description, Module_Link)" +
                    " VALUES (@Code, @Name, @Desc, @Link)";

                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Code", mod.ModuleCode);
                    cmd.Parameters.AddWithValue("@Name", mod.ModuleName);
                    cmd.Parameters.AddWithValue("@Desc", mod.ModuleDescription);
                    cmd.Parameters.AddWithValue("@Link", mod.ModuleResource);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CRITICAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        public void AddStudent(Student stud)
        {
            string DBPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SystemDatabase.mdf";
            string dataSource = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={DBPath};Integrated Security=True";

            SqlConnection con = new SqlConnection(dataSource);

            try
            {
                con.Open();
                var sql = "INSERT INTO StudentTable (Student_Name, Student_Surname, Student_Image, Student_DOB, Student_Gender, Student_Phone, Student_Address)" +
                    " VALUES (@Name, @Surname, @Img, @DOB, @Gender, @Phone, @Address)";

                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Name", stud.StudentName);
                    cmd.Parameters.AddWithValue("@Surname", stud.StudentSurname);
                    cmd.Parameters.AddWithValue("@Img", stud.StudentImage);
                    cmd.Parameters.AddWithValue("@DOB", stud.StudentDOB);
                    cmd.Parameters.AddWithValue("@Gender", stud.StudentGender);
                    cmd.Parameters.AddWithValue("@Phone", stud.StudentPhone);
                    cmd.Parameters.AddWithValue("@Address", stud.StudentAddress);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CRITICAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        public void UpdateStudent(string StudentNumber, Student student, List<Composite> modulesAssigned)
        {

        }

        public void UpdateModule(Module mod, string code)
        {
            string DBPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SystemDatabase.mdf";
            string dataSource = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={DBPath};Integrated Security=True";

            SqlConnection con = new SqlConnection(dataSource);

            try
            {
                con.Open();
                var sql = $"UPDATE ModuleTable SET Module_Name = @Name, Module_Description = @Desc, Module_Link = @Link " +
                    $"WHERE Module_Code = {code}";

                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Name", mod.ModuleName);
                    cmd.Parameters.AddWithValue("@Desc", mod.ModuleDescription);
                    cmd.Parameters.AddWithValue("@Link", mod.ModuleResource);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CRITICAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
