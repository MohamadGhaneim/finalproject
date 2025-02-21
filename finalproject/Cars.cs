using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    internal class Cars
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-DPM0T5TG\SQLEXPRESS;Initial Catalog=CAR_SALES;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        private int carid { get; set; }
        private int price { get; set; }
        private string carmodel { get; set; }
        private string color { get; set; }
        private DateTime year { get; set; }
        private Image picture { get; set; }

        public Cars()
        {
            carid = 0;
            price = 0;
            carmodel = string.Empty;
            color = string.Empty;
            year = DateTime.Now;
            picture = null;
        }

        public DataTable getallcars()
        {
            DataTable dt = new DataTable();
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    String query = "SELECT * FROM Cars";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("erroreeeee");
                }
                finally
                {
                    conn.Close();
                }
                }
            return dt;
        }

        public DataTable getcarbyid(int carid,int finallprice)
        {
            DataTable dt = new DataTable();
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    String query = "SELECT * FROM Cars WHERE carID=@carid";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    
                    cmd.Parameters.AddWithValue("carid", carid);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error");
                }
                finally
                {
                    conn.Close();
                }
            }
            return dt;
        }

    }
}
