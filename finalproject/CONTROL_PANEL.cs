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
    public partial class CONTROL_PANEL : Form
    {
        public CONTROL_PANEL()
        {
            InitializeComponent();
            LoadUserControl(new User_page());
        }
        public CONTROL_PANEL(String username)
        {
            InitializeComponent();
            LoadUserControl(new User_page());
            lbl_AdminName.Text = "welcome "+ username;
        }
        private void LoadUserControl(UserControl uc)
        {
            main_panel.Controls.Clear();  // Remove the existing control
            uc.Dock = DockStyle.Fill;         // Make it fill the panel
            main_panel.Controls.Add(uc);  // Add the new control
        }


        private void CONTROL_PANEL_Load(object sender, EventArgs e)
        {

        }
        
        private void close_click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure to close", "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes) {
                Application.Exit(); 
            }
        }

        private void logout(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure to logout", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                Login n = new Login();
                n.Show();
            }
        }

        private void Add_Car(object sender, EventArgs e)
        {
            if (this.FindForm() is CONTROL_PANEL mainForm)
            {
                mainForm.LoadUserControl(new ADD_CAR()); // Ensure ADD_CAR is a UserControl
            }
            else
            {
                MessageBox.Show("Error: Cannot find the main form.");
            }
        }

        private void USERS(object sender, EventArgs e)
        {
            if (this.FindForm() is CONTROL_PANEL mainForm)
            {
                mainForm.LoadUserControl(new User_page()); // Ensure ADD_CAR is a UserControl
            }
            else
            {
                MessageBox.Show("Error: Cannot find the main form.");
            }
        }
    }
}
