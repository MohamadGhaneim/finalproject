using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class Customer_info : UserControl
    {
        int carid, finalprice , _EMP_ID=1;
        public Customer_info()
        {
            InitializeComponent();
        }
        public Customer_info(int id)
        {
            _EMP_ID = id;
            InitializeComponent();
        }
        public Customer_info(int carid,int finalprice)
        {
            this.carid = carid;
            this.finalprice = finalprice;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //Sale_page sale_Page=new Sale_page();
            //sale_Page.Visible = true;
            //this.Visible = false;
            this.Parent.Controls.Remove(this);
        }

        private void Customer_info_Load(object sender, EventArgs e)
        {
        }

        private void btn_next2_Click(object sender, EventArgs e)
        {
            String name=tbcustomername.Text.ToString();
            String email=tbcustomeremail.Text.ToString();
            String phone=tbcustomerphone.Text.ToString();

            if(name!="" && email !="" && phone != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Sale?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Customer customer = new Customer();
                    int customerid=customer.add_customer(name, email, phone);

                    Sales sales = new Sales();
                    DateTime dateTime=DateTime.Now;
                    int saleid=sales.add_Sale(dateTime, finalprice.ToString(), _EMP_ID, customerid, carid);
                    DataTable dt = sales.getsaledata(saleid);
                    dataGridView2.DataSource = dt;
                    ExportToExcel(dataGridView2);
                    GenerateInvoice(saleid);
                }
                else
                {
                    
                }
            }
            else
            {
                MessageBox.Show("you need to fill all the field");
            }
            
        }

        public void SetCarInfo(int carid, int finalprice)
        {
            this.carid = carid;
            this.finalprice = finalprice;

            Cars cars = new Cars();
            DataTable dt = cars.getcarbyid(carid, finalprice);
            dt.Columns.Add("Final_price", typeof(int));
            foreach (DataRow row in dt.Rows)
            {
                row["Final_price"] = finalprice;
            }
            dataGridView1.DataSource = dt;
        }

        public void ExportToExcel(DataGridView dgv)
        {
            if (dgv.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = null;

                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Exported from cars app";

                for (int i = 1; i < dgv.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("there is no data");
            }
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        public void GenerateInvoice(int saleId)
        {
            Sales sales = new Sales();
            DataTable dt = sales.getsaledata(saleId);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Sale not found!");
                return;
            }

            string filePath = $"C:\\Invoices\\Invoice_{saleId}.pdf";
            Directory.CreateDirectory("C:\\Invoices"); 

            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, stream);
                doc.Open();

                
                iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                Paragraph title = new Paragraph("Invoice", titleFont) { Alignment = Element.ALIGN_CENTER };
                doc.Add(title);
                doc.Add(new Paragraph("\n"));

                
                iTextSharp.text.Font bodyFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                DataRow row = dt.Rows[0];
                doc.Add(new Paragraph($"Invoice ID: {row["SALE_ID"]}", bodyFont));
                doc.Add(new Paragraph($"Sale Date: {Convert.ToDateTime(row["SALE_DATE"]).ToString("yyyy-MM-dd")}", bodyFont));
                doc.Add(new Paragraph($"Sale Price: ${row["SALE_PRICE"]}", bodyFont));
                doc.Add(new Paragraph($"Employee ID: {row["EMP_ID"]}", bodyFont));
                doc.Add(new Paragraph($"Customer ID: {row["CUST_ID"]}", bodyFont));
                doc.Add(new Paragraph($"Car ID: {row["CAR_ID"]}", bodyFont));
                doc.Add(new Paragraph("\nThank you for your purchase!", bodyFont));

                doc.Close();
            }

            MessageBox.Show("Invoice generated successfully! File saved at: " + filePath);
            System.Diagnostics.Process.Start(filePath); 
        }
    }
}
