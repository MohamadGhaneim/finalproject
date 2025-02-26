using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    internal class Cars
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-E1H7K4F\SQLEXPRESS;Initial Catalog=CAR_SALES;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

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
                    MessageBox.Show(ex.Message);
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
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return dt;
        }

        public void InsertCar(String price, string carmodel, string color, String year, String picture)
        {
            try
            {
                string query = "INSERT INTO Cars (price, model, color, year, picture) VALUES (@price, @carmodel, @color, @year, @picture)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    DateTime yearDate = DateTime.Parse(year);
                    int yearInt = yearDate.Year;
                    Validator v = new Validator(); 
                    cmd.Parameters.AddWithValue("@price", v.cleantextUser(price));
                    cmd.Parameters.AddWithValue("@carmodel", v.cleantextUser(carmodel));
                    cmd.Parameters.AddWithValue("@color", v.cleantextUser(color));
                    cmd.Parameters.AddWithValue("@year", yearInt);
                    cmd.Parameters.AddWithValue("@picture", picture);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("car is added !");
                }
            
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

       

    }
}
