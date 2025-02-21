namespace finalproject
{
    partial class CONTROL_PANEL
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CONTROL_PANEL));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.PictureBox();
            this.btn_userpage = new System.Windows.Forms.Button();
            this.btn_sale = new System.Windows.Forms.Button();
            this.btn_addcar = new System.Windows.Forms.Button();
            this.lbl_AdminName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.add_CAR1 = new finalproject.ADD_CAR();
            this.user_page1 = new finalproject.User_page();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_logout);
            this.panel2.Controls.Add(this.btn_userpage);
            this.panel2.Controls.Add(this.btn_sale);
            this.panel2.Controls.Add(this.btn_addcar);
            this.panel2.Controls.Add(this.lbl_AdminName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 511);
            this.panel2.TabIndex = 3;
            // 
            // btn_logout
            // 
            this.btn_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_logout.BackgroundImage")));
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logout.Location = new System.Drawing.Point(44, 413);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(56, 53);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.TabStop = false;
            this.btn_logout.Click += new System.EventHandler(this.logout);
            // 
            // btn_userpage
            // 
            this.btn_userpage.BackColor = System.Drawing.Color.Blue;
            this.btn_userpage.FlatAppearance.BorderSize = 0;
            this.btn_userpage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_userpage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_userpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_userpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userpage.ForeColor = System.Drawing.Color.White;
            this.btn_userpage.Location = new System.Drawing.Point(12, 167);
            this.btn_userpage.Name = "btn_userpage";
            this.btn_userpage.Size = new System.Drawing.Size(133, 56);
            this.btn_userpage.TabIndex = 4;
            this.btn_userpage.Text = "User page";
            this.btn_userpage.UseVisualStyleBackColor = false;
            this.btn_userpage.Click += new System.EventHandler(this.USERS);
            // 
            // btn_sale
            // 
            this.btn_sale.BackColor = System.Drawing.Color.Blue;
            this.btn_sale.FlatAppearance.BorderSize = 0;
            this.btn_sale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_sale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_sale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sale.ForeColor = System.Drawing.Color.White;
            this.btn_sale.Location = new System.Drawing.Point(12, 240);
            this.btn_sale.Name = "btn_sale";
            this.btn_sale.Size = new System.Drawing.Size(133, 56);
            this.btn_sale.TabIndex = 3;
            this.btn_sale.Text = "Sale page";
            this.btn_sale.UseVisualStyleBackColor = false;
            // 
            // btn_addcar
            // 
            this.btn_addcar.BackColor = System.Drawing.Color.Blue;
            this.btn_addcar.FlatAppearance.BorderSize = 0;
            this.btn_addcar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_addcar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_addcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addcar.ForeColor = System.Drawing.Color.White;
            this.btn_addcar.Location = new System.Drawing.Point(12, 313);
            this.btn_addcar.Name = "btn_addcar";
            this.btn_addcar.Size = new System.Drawing.Size(133, 56);
            this.btn_addcar.TabIndex = 2;
            this.btn_addcar.Text = "Add car";
            this.btn_addcar.UseVisualStyleBackColor = false;
            this.btn_addcar.Click += new System.EventHandler(this.Add_Car);
            // 
            // lbl_AdminName
            // 
            this.lbl_AdminName.AutoSize = true;
            this.lbl_AdminName.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminName.Location = new System.Drawing.Point(3, 126);
            this.lbl_AdminName.Name = "lbl_AdminName";
            this.lbl_AdminName.Size = new System.Drawing.Size(0, 17);
            this.lbl_AdminName.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(23, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(847, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(36, 24);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.close_click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(163, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 36);
            this.panel1.TabIndex = 7;
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.add_CAR1);
            this.main_panel.Controls.Add(this.user_page1);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(163, 36);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(883, 475);
            this.main_panel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Logout";
            // 
            // add_CAR1
            // 
            this.add_CAR1.Location = new System.Drawing.Point(0, 0);
            this.add_CAR1.Name = "add_CAR1";
            this.add_CAR1.Size = new System.Drawing.Size(883, 475);
            this.add_CAR1.TabIndex = 1;
            // 
            // user_page1
            // 
            this.user_page1.Location = new System.Drawing.Point(0, 0);
            this.user_page1.Name = "user_page1";
            this.user_page1.Size = new System.Drawing.Size(883, 456);
            this.user_page1.TabIndex = 0;
            // 
            // CONTROL_PANEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 511);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CONTROL_PANEL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTROL_PANEL";
            this.Load += new System.EventHandler(this.CONTROL_PANEL_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_AdminName;
        private System.Windows.Forms.Button btn_addcar;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_userpage;
        private System.Windows.Forms.Button btn_sale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.PictureBox btn_logout;
        private User_page user_page1;
        private System.Windows.Forms.Label label2;
        private ADD_CAR add_CAR1;
    }
}