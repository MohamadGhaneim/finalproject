using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace finalproject
{
    internal class Customer
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-DPM0T5TG\SQLEXPRESS;Initial Catalog=CAR_SALES;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        private int customerid { get; set; }
        private string customername { get; set; }
        private string customeremail { get; set; }
        private string customerphone { get; set; }

        public Customer()
        {
            customerid = 0;
            customername = string.Empty;
            customeremail = string.Empty;
            customerphone = string.Empty;
        }

        public int add_customer(string name, string email, string phone)
        {
            int customerid = -1;

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string query1 = "SELECT custID FROM Customers WHERE cust_name=@name AND cust_phone=@phone AND cust_email=@email";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                cmd1.Parameters.AddWithValue("@name", name);
                cmd1.Parameters.AddWithValue("@phone", phone);
                cmd1.Parameters.AddWithValue("@email", email);

                object result1 = cmd1.ExecuteScalar(); 

                if (result1 != null)  
                {
                    customerid = Convert.ToInt32(result1);
                    MessageBox.Show("Customer already exists. ID: " + customerid);
                }
                else
                {
                    string query = "INSERT INTO Customers(cust_name, cust_phone, cust_email) OUTPUT INSERTED.custID VALUES(@name, @phone, @email)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        customerid = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Error adding customer.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return customerid;
        }
    }
}
