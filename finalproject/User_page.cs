using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace finalproject
{
    public partial class User_page : UserControl
    {
        public User_page()
        {
            InitializeComponent();
            cb_rank.Items.Add("employee");
            cb_rank.Items.Add("admin");
        }
        

        private void insert_user(object sender, EventArgs e)
        {
            
           
            EMPLOYEE add_Employee = new EMPLOYEE();
            add_Employee.EMP_NAME = txt_fname.Text;
            add_Employee.EMP_EMAIL = txt_email.Text.Trim();
            add_Employee.EMP_PHONE = txt_phone.Text.Trim();
            add_Employee.EMP_rank = cb_rank.Text;
            add_Employee.userName = txt_username.Text.Trim();
            add_Employee.userPass = txt_password.Text.Trim();
            add_Employee.EMP_Village = txt_village.Text.Trim();
            add_Employee.Emp_registration();
            clean();

        }

        private void select_user(object sender, EventArgs e)
        {
            if (txt_ID.Text.Trim() == "")
            {
                
                EMPLOYEE select = new EMPLOYEE();
                DataTable dt = select.Select_user();
                dgv_user.DataSource = dt;
                MessageBox.Show("fill the id", "", MessageBoxButtons.OK);
            }
            else
            {
                EMPLOYEE select = new EMPLOYEE();
                int employeeId = int.Parse(txt_ID.Text);
                DataTable dt = select.Select_user(employeeId);
                dgv_user.DataSource = dt;
            }
        }

        private void select_all_users(object sender, EventArgs e)
        {
            EMPLOYEE select = new EMPLOYEE();
            DataTable dt = select.Select_user();
            dgv_user.DataSource = dt;
        }

        private void update_user(object sender, EventArgs e)
        {
            EMPLOYEE add_Employee = new EMPLOYEE();
            add_Employee.EMP_NAME = txt_fname.Text;
            add_Employee.EMP_EMAIL = txt_email.Text.Trim();
            add_Employee.EMP_PHONE = txt_phone.Text.Trim();
            add_Employee.EMP_rank = cb_rank.Text;
            add_Employee.userName = txt_username.Text.Trim();
            add_Employee.userPass = txt_password.Text.Trim();
            add_Employee.EMP_Village = txt_village.Text.Trim();

            EMPLOYEE select = new EMPLOYEE();
            if (txt_ID.Text != "") {
                int employeeId = int.Parse(txt_ID.Text);
                add_Employee.Emp_update_info(employeeId);
                clean();
                DataTable dt = select.Select_user();
                dgv_user.DataSource = dt;
            }
            else
            {
                MessageBox.Show("fill the ID ", "Warning", MessageBoxButtons.OK);
            }
            
        }

        private void check_int_id(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
                MessageBox.Show("Only numbers are allowed!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgv_user.Rows[e.RowIndex];

                txt_ID.Text = row.Cells["empID"].Value.ToString();
                txt_fname.Text = row.Cells["EMP_NAME"].Value.ToString();
                txt_email.Text = row.Cells["EMP_EMAIL"].Value.ToString();
                txt_phone.Text = row.Cells["EMP_PHONE"].Value.ToString();
                cb_rank.Text = row.Cells["EMP_rank"].Value.ToString();
                txt_username.Text = row.Cells["userName"].Value.ToString();
                //txt_password.Text = row.Cells["userPass"].Value.ToString();
                txt_village.Text = row.Cells["EMP_Village"].Value.ToString();
            }
        }

        private void reset_txt(object sender, EventArgs e)
        {
            clean();
        }

        public void clean()
        {
            // Clear all textboxes
            txt_ID.Clear();
            txt_fname.Clear();
            txt_email.Clear();
            txt_phone.Clear();
            cb_rank.Text="";
            txt_username.Clear();
            txt_password.Clear();
            txt_village.Clear();
            EMPLOYEE select = new EMPLOYEE();
            DataTable dt = select.Select_user();
            dgv_user.DataSource = dt;

        }

        private void delete_user(object sender, EventArgs e)
        {
            if (txt_ID.Text.Trim() == "")
            {
                MessageBox.Show("fill the id", "", MessageBoxButtons.OK);
            }
            else
            {
                EMPLOYEE select = new EMPLOYEE();
                int employeeId = int.Parse(txt_ID.Text);
                select.delete_user(employeeId);
                clean();
            }
        }
    }
}
