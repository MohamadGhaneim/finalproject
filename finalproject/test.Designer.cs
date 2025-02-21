namespace finalproject
{
    partial class test
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.customer_info1 = new finalproject.Customer_info();
            this.sale_page1 = new finalproject.Sale_page();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sale_page1);
            this.panel1.Controls.Add(this.customer_info1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 517);
            this.panel1.TabIndex = 0;
            // 
            // customer_info1
            // 
            this.customer_info1.Location = new System.Drawing.Point(0, 0);
            this.customer_info1.Name = "customer_info1";
            this.customer_info1.Size = new System.Drawing.Size(944, 517);
            this.customer_info1.TabIndex = 1;
            // 
            // sale_page1
            // 
            this.sale_page1.Location = new System.Drawing.Point(1, 2);
            this.sale_page1.Name = "sale_page1";
            this.sale_page1.Size = new System.Drawing.Size(940, 515);
            this.sale_page1.TabIndex = 2;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 517);
            this.Controls.Add(this.panel1);
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Customer_info customer_info1;
        private Sale_page sale_page1;
    }
}