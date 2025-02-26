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
    public partial class EMPLOYEE_CONTROL : Form
    {
        public EMPLOYEE_CONTROL()
        {
            InitializeComponent();
            LoadUserControl(new Sale_page());
        }
        
        private void LoadUserControl(UserControl uc)
        {
            main_panel.Controls.Clear();  // Remove the existing control
            uc.Dock = DockStyle.Fill;         // Make it fill the panel
            main_panel.Controls.Add(uc);  // Add the new control
        }

        private void EMPLOYEE_CONTROL_Load(object sender, EventArgs e)
        {
            
        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
