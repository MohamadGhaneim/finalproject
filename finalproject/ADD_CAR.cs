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
    public partial class ADD_CAR : UserControl
    {
        public ADD_CAR()
        {
            InitializeComponent();
        }

        private void add_picture(object sender, EventArgs e)
        {
            openPicture.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openPicture.Title = "Select an Image";

            if (openPicture.ShowDialog() == DialogResult.OK)
            {
                // Display the selected image in the PictureBox
                picture_bx.Image = Image.FromFile(openPicture.FileName);
            }
        }

        private void insert_car(object sender, EventArgs e)
        {
            if(txtprice.Text.ToString().Trim()=="" || cbtypeCar.Text.ToString().Trim() == "")
            {
                MessageBox.Show("all fields are required");
            }
            else
            {
                Cars c = new Cars();
                String imagePath = openPicture.FileName;
                c.InsertCar(txtprice.Text.ToString(), cbtypeCar.Text.ToString(), txt_color.Text.ToString(), dt_date.Text.ToString() , imagePath);
            }
        }
    }
}
