using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;

namespace finalproject
{
    internal class EMPLOYEE
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-E1H7K4F\SQLEXPRESS;Initial Catalog=CAR_SALES;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        public int empID { get; set; }
        public string EMP_NAME { get; set; }
        public string EMP_EMAIL { get; set; }
        public string EMP_PHONE { get; set; }
        public string EMP_rank { get; set; }
        public string userName { get; set; }
        public string userPass { get; set; }
        public string EMP_Village { get; set; }
        public DateTime Startdate { get; set; }

        public EMPLOYEE()
        {
            empID = 0;
            EMP_NAME= string.Empty;
            EMP_EMAIL= string.Empty;
            EMP_PHONE = string.Empty;
            EMP_rank=string.Empty;
            userName = string.Empty;
            userPass = string.Empty;
            EMP_Village = string.Empty;
            Startdate = DateTime.Now;
        }
        

        public void Emp_Login(String username,String password, Login currentForm)
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    String query = "SELECT * FROM Employees WHERE userName=@username" +
                        " AND userPass=@userpass";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        Validator hashpassword = new Validator();
                        String hash_password = hashpassword.HashPassword(password);

                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("userpass", hash_password);

                        
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            string columnValue = (string)dt.Rows[0]["EMP_rank"];
                            int emp_id = (int)dt.Rows[0]["empID"];

                            if (columnValue == "admin")
                            {
                                MessageBox.Show(emp_id.ToString());
                                string Name_admin = (string)dt.Rows[0]["EMP_NAME"];
                                CONTROL_PANEL cONTROL_PANEL=new CONTROL_PANEL(Name_admin);
                                Customer_info customer = new Customer_info(emp_id);
                                currentForm.Hide();
                                cONTROL_PANEL.Show();
                                return;
                            }
                             if (columnValue == "employee")
                            {
                                
                                EMPLOYEE_CONTROL ec = new EMPLOYEE_CONTROL();
                                Customer_info customer = new Customer_info(emp_id);
                                currentForm.Hide();
                                ec.Show();
                                return;
                            }
                           
                        }
                        else
                        {
                            MessageBox.Show("user not found !");
                        }
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message + "\n\nDetails:\n" + e.StackTrace, "Exception Details", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Error", "Connection state not good" );
            }
        }

        public void Emp_registration()
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Employees WHERE userName=@username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", userName);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Username already exists.", "Ops", MessageBoxButtons.OK);
                        }
                        else
                        {
                            string insertEmployeeQuery = @"INSERT INTO Employees (EMP_NAME, EMP_EMAIL, EMP_PHONE, EMP_rank, userName, userPass, EMP_Village, Startdate) 
                                                    VALUES (@Name, @Email, @Phone, @Rank, @User, @Password, @Village, GETDATE())";

                            using (SqlCommand insertCmd = new SqlCommand(insertEmployeeQuery, conn))
                            {
                                Validator valid = new Validator();
                                string hashedPassword = valid.HashPassword(valid.cleantextUser(userPass));

                                insertCmd.Parameters.AddWithValue("@Name", valid.cleantextUser(EMP_NAME));
                                insertCmd.Parameters.AddWithValue("@Email", valid.cleantextUser(EMP_EMAIL)); 
                                insertCmd.Parameters.AddWithValue("@Phone", valid.cleantextUser(EMP_PHONE));
                                insertCmd.Parameters.AddWithValue("@Rank", valid.cleantextUser(EMP_rank));
                                insertCmd.Parameters.AddWithValue("@User", valid.cleantextUser(userName));
                                insertCmd.Parameters.AddWithValue("@Password", hashedPassword);
                                insertCmd.Parameters.AddWithValue("@Village", valid.cleantextUser(EMP_Village));
                                if (valid.cleantextUser(EMP_NAME)=="" || valid.cleantextUser(EMP_EMAIL)==""|| valid.cleantextUser(EMP_PHONE)=="" 
                                    || valid.cleantextUser(EMP_rank)=="" || valid.cleantextUser(userName)=="" || valid.cleantextUser(EMP_Village)=="" || valid.cleantextUser(userPass)=="")
                                {
                                    MessageBox.Show("all fields are required !");
                                }
                                else
                                {
                                    insertCmd.ExecuteNonQuery();
                                    MessageBox.Show("Success !");
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message + "\n\nDetails:\n" + e.StackTrace, "Exception Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Error", "Connection state not good.");
            }
        }
  
        public void Emp_update_info(int id)
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Employees WHERE userName=@username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", userName);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        //_Old_pass = (string)dt.Rows[0]["userPass"];
                        if (dt.Rows.Count > 1)
                        {
                            MessageBox.Show("Username already exists.", "Ops", MessageBoxButtons.OK);
                        }
                        else
                        {
                            string update_query = @"UPDATE Employees SET EMP_NAME = @Name, EMP_EMAIL = @Email,
                           EMP_PHONE = @Phone, EMP_rank = @Rank, 
                           userName = @User,  userPass = @Password, EMP_Village = @Village WHERE empID = @id";

                            using (SqlCommand insertCmd = new SqlCommand(update_query, conn))
                            {
                                Validator valid = new Validator();

                                if (valid.cleantextUser(EMP_NAME) == "" || valid.cleantextUser(EMP_EMAIL) == "" || valid.cleantextUser(EMP_PHONE) == ""
                                    || valid.cleantextUser(EMP_rank) == "" || valid.cleantextUser(userName) == "" || valid.cleantextUser(EMP_Village) == "" || valid.cleantextUser(userPass) == "")
                                {
                                    MessageBox.Show("all fields are required !");
                                }
                                else
                                {
                                    insertCmd.Parameters.AddWithValue("@id", valid.cleantextUser(id));
                                    insertCmd.Parameters.AddWithValue("@Name", valid.cleantextUser(EMP_NAME));
                                    insertCmd.Parameters.AddWithValue("@Email", valid.cleantextUser(EMP_EMAIL));
                                    insertCmd.Parameters.AddWithValue("@Phone", valid.cleantextUser(EMP_PHONE));
                                    insertCmd.Parameters.AddWithValue("@Rank", valid.cleantextUser(EMP_rank));
                                    insertCmd.Parameters.AddWithValue("@User", valid.cleantextUser(userName));
                                    insertCmd.Parameters.AddWithValue("@Password", valid.HashPassword(userPass));
                                    insertCmd.Parameters.AddWithValue("@Village", valid.cleantextUser(EMP_Village));

                                    insertCmd.ExecuteNonQuery();
                                    MessageBox.Show("Success !");
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Error", "Connection state not good.");
            }
        }

        public DataTable Select_user(int id)
        {
            string query = "SELECT * FROM Employees WHERE empID = @id"; 
            DataTable dt = new DataTable();

            using ( SqlCommand connection = new SqlCommand(query,conn))
            {
                connection.Parameters.AddWithValue("@id", id);

                    try
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(connection);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
            }
            return dt;
        }

        public DataTable Select_user()
        {
            string query = "SELECT * FROM Employees"; 
            DataTable dt = new DataTable();
            
            using (SqlCommand connection = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(connection);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return dt;
        }

       public void delete_user(int ID)
        {
            if(conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string select_for_delete = "SELECT * FROM Employees WHERE empID =" + ID.ToString() ;
                    SqlCommand cmd = new SqlCommand(select_for_delete, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count!=1)
                    {
                        MessageBox.Show("user not found", "ops !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        DialogResult result = new DialogResult();
                        result= MessageBox.Show("this user will be deleted", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            String delete = "DELETE FROM Employees WHERE empID = @ID";
                            using(SqlCommand cmd_delete = new SqlCommand(delete, conn))
                            {
                                cmd_delete.Parameters.AddWithValue("@ID",ID);
                                cmd_delete.ExecuteNonQuery();
                                MessageBox.Show("user is deleted", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally 
                {
                    conn.Close();
                }
            }
        }
    }
}


