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
        }

        

        private void CONTROL_PANEL_Load(object sender, EventArgs e)
        {

        }
        
        private void close_click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure to close", "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes) { 
                Close();
            }
        }
    }
}
