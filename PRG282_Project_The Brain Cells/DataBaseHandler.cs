using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_The_Brain_Cells
{
    internal class DataBaseHandler
    {
        DataHandler data = new DataHandler();
        
        public List<Module> GetModules()
        {
            
            List<Module> modules = new List<Module>();
            DataSet dataSet = new DataSet();

            string DBPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SystemDatabase.mdf";
            string dataSource = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={DBPath};Integrated Security=True";

            SqlConnection con = new SqlConnection(dataSource);

            SqlDataAdapter adapter = new SqlDataAdapter("Exec SelectAllModules", con);

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
        public List<Module> GetStudentModules(int Num)
        {
            List<Module> modules = new List<Module>();
            DataSet dataSet = new DataSet();

            string DBPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SystemDatabase.mdf";
            string dataSource = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={DBPath};Integrated Security=True";

            SqlConnection con = new SqlConnection(dataSource);

            SqlDataAdapter adapter = new SqlDataAdapter($"EXEC SelectModuleInfoByStudentNum @StudentNum = {Num}", con);

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

            SqlDataAdapter adapter = adapter = new SqlDataAdapter("Exec SelectAllStudents", con);

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

            SqlDataAdapter adapter = adapter = new SqlDataAdapter("Exec SelectAllComposites", con);

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

            SqlDataAdapter adapter = adapter = new SqlDataAdapter("Exec SelectAllCredentials", con);

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

            SqlDataAdapter adapter = adapter = new SqlDataAdapter("Exec SelectAllCredentials", con);

            adapter.Fill(dataSet);

            List<Credential> credentials = dataSet.Tables[0].AsEnumerable().Select(dataRow => new Credential
            {
                Username = dataRow.Field<string>("Username"),
                Password = dataRow.Field<string>("Password")

            }).ToList();

            foreach (var cred in credentials)
            {
                if (cred.Username == Username)
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

                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Username", cred.Username);
                    cmd.Parameters.AddWithValue("@Password", cred.Password);

                    cmd.ExecuteNonQuery();
                }
                data.AddToLogFile("Credential Added: " + cred.Username);
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
                var sql = "EXEC ModuleInsert @Code, @Name,@Desc,@Link";

                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Code", mod.ModuleCode);
                    cmd.Parameters.AddWithValue("@Name", mod.ModuleName);
                    cmd.Parameters.AddWithValue("@Desc", mod.ModuleDescription);
                    cmd.Parameters.AddWithValue("@Link", mod.ModuleResource);

                    cmd.ExecuteNonQuery();
                }
                data.AddToLogFile("Module Added: " + mod.ModuleCode);
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
                var sql = "Exec InsertStudent @Name, @Surname, @Img, @DOB, @Gender, @Phone, @Address";

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
                data.AddToLogFile("Student Added: " + stud.StudentName +" "+ stud.StudentSurname);
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

        public void UpdateStudent(Student stud)
        {
            string DBPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SystemDatabase.mdf";
            string dataSource = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={DBPath};Integrated Security=True";

            SqlConnection con = new SqlConnection(dataSource);

            try
            {
                con.Open();
                var sql = "Exec StudentUpdate @Num, @Name, @Surname, @Img, @DOB, @Gender, @Phone, @Address";

                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Num", stud.StudentNumber);
                    cmd.Parameters.AddWithValue("@Name", stud.StudentName);
                    cmd.Parameters.AddWithValue("@Surname", stud.StudentSurname);
                    cmd.Parameters.AddWithValue("@Img", stud.StudentImage);
                    cmd.Parameters.AddWithValue("@DOB", stud.StudentDOB);
                    cmd.Parameters.AddWithValue("@Gender", stud.StudentGender);
                    cmd.Parameters.AddWithValue("@Phone", stud.StudentPhone);
                    cmd.Parameters.AddWithValue("@Address", stud.StudentAddress);

                    cmd.ExecuteNonQuery();
                }
                data.AddToLogFile("Student Updated: " + stud.StudentName + " " + stud.StudentSurname);
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

        public void InsertComposite(Composite comp)
        {
            string DBPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SystemDatabase.mdf";
            string dataSource = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={DBPath};Integrated Security=True";

            SqlConnection con = new SqlConnection(dataSource);

            try
            {
                con.Open();

                var compSql = "Exec CompositeInsert @StudentNum,@ModuleCode";
                using (var cmd = new SqlCommand(compSql, con))
                {

                    cmd.Parameters.AddWithValue("@StudentNum", comp.StudentNumber);
                    cmd.Parameters.AddWithValue("@ModuleCode", comp.ModuleCode);

                    cmd.ExecuteNonQuery();
                }
                data.AddToLogFile("Composite Added: " + comp.StudentNumber + " " + comp.ModuleCode);
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

        public void RemoveComposite(Composite comp)
        {
            string DBPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SystemDatabase.mdf";
            string dataSource = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={DBPath};Integrated Security=True";

            SqlConnection con = new SqlConnection(dataSource);

            try
            {
                con.Open();

                var compSql = "Exec CompositeDelete @StudentNum,@ModuleCode";
                using (var cmd = new SqlCommand(compSql, con))
                {

                    cmd.Parameters.AddWithValue("@StudentNum", comp.StudentNumber);
                    cmd.Parameters.AddWithValue("@ModuleCode", comp.ModuleCode);

                    cmd.ExecuteNonQuery();
                }
                data.AddToLogFile("Composite Removed: " + comp.StudentNumber + " " + comp.ModuleCode);
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

        public void UpdateModule(Module mod)
        {
            string DBPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SystemDatabase.mdf";
            string dataSource = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={DBPath};Integrated Security=True";

            SqlConnection con = new SqlConnection(dataSource);

            try
            {
                con.Open();
                var sql = "Exec ModuleUpdate @Code,@Name,@Desc,@Link";

                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Code", mod.ModuleCode);
                    cmd.Parameters.AddWithValue("@Name", mod.ModuleName);
                    cmd.Parameters.AddWithValue("@Desc", mod.ModuleDescription);
                    cmd.Parameters.AddWithValue("@Link", mod.ModuleResource);

                    cmd.ExecuteNonQuery();
                }
                data.AddToLogFile("Module update: " + mod.ModuleCode);
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

        public void RemoveModule(Module mod)
        {
            string DBPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SystemDatabase.mdf";
            string dataSource = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={DBPath};Integrated Security=True";

            SqlConnection con = new SqlConnection(dataSource);

            try
            {
                con.Open();
                var sql = "Exec ModuleDelete @Code";

                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Code", mod.ModuleCode);

                    cmd.ExecuteNonQuery();
                }
                data.AddToLogFile("Module removed: " + mod.ModuleCode);
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

        public void RemoveCompModule(string ModuleCode)
        {
            string DBPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SystemDatabase.mdf";
            string dataSource = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={DBPath};Integrated Security=True";

            SqlConnection con = new SqlConnection(dataSource);

            try
            {
                con.Open();
                var sql = "Exec CompDelMod @Code";

                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Code", ModuleCode);

                    cmd.ExecuteNonQuery();
                }
                data.AddToLogFile("Composite module removed: " + ModuleCode);
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

        public void RemoveStudent(Student student)
        {
            string DBPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SystemDatabase.mdf";
            string dataSource = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={DBPath};Integrated Security=True";

            SqlConnection con = new SqlConnection(dataSource);

            try
            {
                con.Open();
                var sql = "Exec StudentDelete @StudNum";

                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@StudNum", student.StudentNumber);

                    cmd.ExecuteNonQuery();
                }
                data.AddToLogFile("Student removed: " + student.StudentNumber);
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

        public void RemoveCompStudent(int StudentNumber)
        {
            string DBPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SystemDatabase.mdf";
            string dataSource = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={DBPath};Integrated Security=True";

            SqlConnection con = new SqlConnection(dataSource);

            try
            {
                con.Open();
                var sql = "Exec CompDelStud @StudNum";

                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@StudNum", StudentNumber);

                    cmd.ExecuteNonQuery();
                }
                data.AddToLogFile("Composite student removed: " + StudentNumber.ToString());
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

        public void RemoveCredential(Credential cred)
        {
            string DBPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SystemDatabase.mdf";
            string dataSource = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={DBPath};Integrated Security=True";

            SqlConnection con = new SqlConnection(dataSource);

            try
            {
                con.Open();
                var sql = "Exec CredentialDelete @Username";

                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Username", cred.Username);

                    cmd.ExecuteNonQuery();
                }
                data.AddToLogFile("Credential removed: " + cred.Username);
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
