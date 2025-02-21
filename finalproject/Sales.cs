using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    internal class Sales
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-DPM0T5TG\SQLEXPRESS;Initial Catalog=CAR_SALES;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        private int saleid {  get; set; }
        private DateTime saledate { get; set; }
        private string saleprice {  get; set; }
        private int empid {  get; set; }
        private int custid {  get; set; }
        private int carid {  get; set; }

        public int add_Sale(DateTime saledate, string saleprice, int empid, int custid, int carid)
        {
            int saleid = -1;
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Sales(SALE_DATE,SALE_PRICE,EMP_ID,CUST_ID,CAR_ID)" +
                        " OUTPUT INSERTED.SALE_ID VALUES(@saledate,@saleprice,@empid,@custid,@carid)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("saledate", saledate);
                    cmd.Parameters.AddWithValue("saleprice", saleprice);
                    cmd.Parameters.AddWithValue("empid", empid);
                    cmd.Parameters.AddWithValue("custid", custid);
                    cmd.Parameters.AddWithValue("carid", carid);
                    object result = cmd.ExecuteScalar();
                    if (result !=null)
                    {
                        saleid = Convert.ToInt32(result);
                        MessageBox.Show("Sale success");

                    }
                    else
                    {
                        MessageBox.Show("Error making the sale");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: "+ex.Message);
                }finally 
                { 
                    conn.Close(); 
                }
            }
            return saleid;
        }
        public DataTable getsaledata(int saleid)
        {
            DataTable dt = new DataTable();
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    String query = "SELECT * FROM Sales WHERE SALE_ID=@saleid";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("saleid", saleid);

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
