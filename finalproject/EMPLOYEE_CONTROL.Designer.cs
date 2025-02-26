namespace finalproject
{
    partial class EMPLOYEE_CONTROL
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
            this.main_panel = new System.Windows.Forms.Panel();
            this.customer_info1 = new finalproject.Customer_info();
            this.sale_page1 = new finalproject.Sale_page();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.customer_info1);
            this.main_panel.Controls.Add(this.sale_page1);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(947, 496);
            this.main_panel.TabIndex = 0;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            // 
            // customer_info1
            // 
            this.customer_info1.Location = new System.Drawing.Point(0, 0);
            this.customer_info1.Name = "customer_info1";
            this.customer_info1.Size = new System.Drawing.Size(883, 475);
            this.customer_info1.TabIndex = 1;
            // 
            // sale_page1
            // 
            this.sale_page1.Location = new System.Drawing.Point(0, 0);
            this.sale_page1.Name = "sale_page1";
            this.sale_page1.Size = new System.Drawing.Size(883, 475);
            this.sale_page1.TabIndex = 0;
            // 
            // EMPLOYEE_CONTROL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 496);
            this.Controls.Add(this.main_panel);
            this.Name = "EMPLOYEE_CONTROL";
            this.Text = "EMPLOYEE_CONTROL";
            this.Load += new System.EventHandler(this.EMPLOYEE_CONTROL_Load);
            this.main_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private Customer_info customer_info1;
        private Sale_page sale_page1;
    }
}