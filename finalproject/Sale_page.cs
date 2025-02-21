using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class Sale_page : UserControl
    {
        DataTable _dt = new DataTable();
        int _index;
        
        public Sale_page()
        {
            InitializeComponent();
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            if(TBcarid.Text != "" && TBcarmodel.Text != "" && TBcarprice.Text != "" && TBfinallprice.Text != "")
            {
                int carid = int.Parse(TBcarid.Text);
                int finallprice = int.Parse(TBfinallprice.Text);

                Customer_info customer = this.Parent.Controls.OfType<Customer_info>().FirstOrDefault();
                if (customer != null)
                {
                    customer.SetCarInfo(carid, finallprice);
                    customer.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("you need to fill all the field");
            }
        }

        private void Sale_page_Load(object sender, EventArgs e)
        {
          
            Cars cars = new Cars();
            DGVcarssale.DataSource = cars.getallcars();
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            TBcarid.Clear();
            TBcarmodel.Clear();
            TBcarprice.Clear();
            TBfinallprice.Clear();
            PBcarpicture.Enabled = false;
        }

        private void DGVcarssale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            _index = e.RowIndex;

            DataGridViewRow row = DGVcarssale.Rows[_index];

            if (row != null)
            {
                TBcarid.Text = row.Cells[0].Value.ToString();
                TBcarmodel.Text = row.Cells[1].Value.ToString();
                TBcarprice.Text=row.Cells[3].Value.ToString();
                //PBcarpicture.
            }
        }
    }
}
