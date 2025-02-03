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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            String username = TBusername.Text.Trim();
            String password= TBpassword.Text.Trim();

            if(username!="" && password != "")
            {
                EMPLOYEE emp = new EMPLOYEE();
               emp.Emp_Login(username, password,this);
            }
            else
            {
                MessageBox.Show("you need to fill all the fild");
            }
        }
    }
}
