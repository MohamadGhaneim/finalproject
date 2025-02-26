namespace finalproject
{
    partial class ADD_CAR
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbtypeCar = new System.Windows.Forms.ComboBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txt_carnumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picture_bx = new System.Windows.Forms.PictureBox();
            this.openPicture = new System.Windows.Forms.OpenFileDialog();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.btn_insert_car = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_color = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_bx)).BeginInit();
            this.SuspendLayout();
            // 
            // cbtypeCar
            // 
            this.cbtypeCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtypeCar.FormattingEnabled = true;
            this.cbtypeCar.Location = new System.Drawing.Point(104, 143);
            this.cbtypeCar.Name = "cbtypeCar";
            this.cbtypeCar.Size = new System.Drawing.Size(167, 28);
            this.cbtypeCar.TabIndex = 20;
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(105, 90);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(168, 29);
            this.txtprice.TabIndex = 19;
            // 
            // txt_carnumber
            // 
            this.txt_carnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_carnumber.Location = new System.Drawing.Point(105, 31);
            this.txt_carnumber.Name = "txt_carnumber";
            this.txt_carnumber.Size = new System.Drawing.Size(167, 29);
            this.txt_carnumber.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "CAR ID";
            // 
            // picture_bx
            // 
            this.picture_bx.ImageLocation = "openPicture";
            this.picture_bx.Location = new System.Drawing.Point(16, 291);
            this.picture_bx.Name = "picture_bx";
            this.picture_bx.Size = new System.Drawing.Size(259, 169);
            this.picture_bx.TabIndex = 21;
            this.picture_bx.TabStop = false;
            this.picture_bx.Click += new System.EventHandler(this.add_picture);
            // 
            // openPicture
            // 
            this.openPicture.FileName = "openPicture";
            // 
            // dt_date
            // 
            this.dt_date.Location = new System.Drawing.Point(105, 195);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(168, 20);
            this.dt_date.TabIndex = 22;
            // 
            // txt_color
            // 
            this.txt_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_color.Location = new System.Drawing.Point(105, 241);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(168, 29);
            this.txt_color.TabIndex = 23;
            // 
            // btn_insert_car
            // 
            this.btn_insert_car.BackColor = System.Drawing.Color.Blue;
            this.btn_insert_car.FlatAppearance.BorderSize = 0;
            this.btn_insert_car.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_insert_car.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_insert_car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert_car.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert_car.ForeColor = System.Drawing.Color.White;
            this.btn_insert_car.Location = new System.Drawing.Point(311, 364);
            this.btn_insert_car.Name = "btn_insert_car";
            this.btn_insert_car.Size = new System.Drawing.Size(133, 56);
            this.btn_insert_car.TabIndex = 24;
            this.btn_insert_car.Text = "insert car";
            this.btn_insert_car.UseVisualStyleBackColor = false;
            this.btn_insert_car.Click += new System.EventHandler(this.insert_car);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(28, 195);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(48, 24);
            this.lbl_date.TabIndex = 25;
            this.lbl_date.Text = "Date";
            // 
            // btn_color
            // 
            this.btn_color.AutoSize = true;
            this.btn_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_color.Location = new System.Drawing.Point(32, 241);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(52, 24);
            this.btn_color.TabIndex = 26;
            this.btn_color.Text = "color";
            // 
            // ADD_CAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.btn_insert_car);
            this.Controls.Add(this.txt_color);
            this.Controls.Add(this.dt_date);
            this.Controls.Add(this.picture_bx);
            this.Controls.Add(this.cbtypeCar);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txt_carnumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ADD_CAR";
            this.Size = new System.Drawing.Size(883, 475);
            ((System.ComponentModel.ISupportInitialize)(this.picture_bx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbtypeCar;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txt_carnumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picture_bx;
        private System.Windows.Forms.OpenFileDialog openPicture;
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.Button btn_insert_car;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label btn_color;
    }
}
