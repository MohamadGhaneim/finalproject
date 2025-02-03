using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    internal class EMPLOYEE
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-DPM0T5TG\SQLEXPRESS;Initial Catalog=CAR_SALES;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        private int empID { get; set; }
        private string EMP_NAME { get; set; }
        private string EMP_EMAIL { get; set; }
        private string EMP_PHONE { get; set; }
        private string EMP_rank { get; set; }
        private string userName { get; set; }
        private string userPass { get; set; }
        private string EMP_Village { get; set; }
        private DateTime Startdate { get; set; }

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
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("userpass", password);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            string columnValue = (string)dt.Rows[0]["EMP_rank"];
                            if (columnValue == "admin")
                            {
                                CONTROL_PANEL cONTROL_PANEL=new CONTROL_PANEL();
                                currentForm.Hide();
                                cONTROL_PANEL.Show();

                            }else if (columnValue == "employee")
                            {

                            }
                            else
                            {
                                MessageBox.Show("errorrrrrrr");
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
                MessageBox.Show("Error", "Connection state not good" );
            }
        }
    }
}
