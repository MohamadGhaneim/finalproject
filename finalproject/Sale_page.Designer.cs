namespace finalproject
{
    partial class Sale_page
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
            this.DGVcarssale = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PBcarpicture = new System.Windows.Forms.PictureBox();
            this.TBcarid = new System.Windows.Forms.TextBox();
            this.TBfinallprice = new System.Windows.Forms.TextBox();
            this.TBcarprice = new System.Windows.Forms.TextBox();
            this.TBcarmodel = new System.Windows.Forms.TextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcarssale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBcarpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVcarssale
            // 
            this.DGVcarssale.AllowUserToAddRows = false;
            this.DGVcarssale.AllowUserToDeleteRows = false;
            this.DGVcarssale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVcarssale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcarssale.Location = new System.Drawing.Point(357, 18);
            this.DGVcarssale.Name = "DGVcarssale";
            this.DGVcarssale.ReadOnly = true;
            this.DGVcarssale.Size = new System.Drawing.Size(525, 456);
            this.DGVcarssale.TabIndex = 0;
            this.DGVcarssale.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVcarssale_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Finall Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Car Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Car Model";
            // 
            // PBcarpicture
            // 
            this.PBcarpicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBcarpicture.Location = new System.Drawing.Point(167, 304);
            this.PBcarpicture.Name = "PBcarpicture";
            this.PBcarpicture.Size = new System.Drawing.Size(184, 168);
            this.PBcarpicture.TabIndex = 5;
            this.PBcarpicture.TabStop = false;
            // 
            // TBcarid
            // 
            this.TBcarid.Location = new System.Drawing.Point(118, 44);
            this.TBcarid.Name = "TBcarid";
            this.TBcarid.Size = new System.Drawing.Size(233, 20);
            this.TBcarid.TabIndex = 6;
            // 
            // TBfinallprice
            // 
            this.TBfinallprice.Location = new System.Drawing.Point(118, 246);
            this.TBfinallprice.Name = "TBfinallprice";
            this.TBfinallprice.Size = new System.Drawing.Size(233, 20);
            this.TBfinallprice.TabIndex = 7;
            // 
            // TBcarprice
            // 
            this.TBcarprice.Location = new System.Drawing.Point(118, 176);
            this.TBcarprice.Name = "TBcarprice";
            this.TBcarprice.Size = new System.Drawing.Size(233, 20);
            this.TBcarprice.TabIndex = 8;
            // 
            // TBcarmodel
            // 
            this.TBcarmodel.Location = new System.Drawing.Point(118, 104);
            this.TBcarmodel.Name = "TBcarmodel";
            this.TBcarmodel.Size = new System.Drawing.Size(233, 20);
            this.TBcarmodel.TabIndex = 9;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Green;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.Location = new System.Drawing.Point(28, 392);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(133, 56);
            this.btn_next.TabIndex = 22;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Red;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(28, 304);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(133, 56);
            this.btn_clear.TabIndex = 23;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Sale_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.TBcarmodel);
            this.Controls.Add(this.TBcarprice);
            this.Controls.Add(this.TBfinallprice);
            this.Controls.Add(this.TBcarid);
            this.Controls.Add(this.PBcarpicture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVcarssale);
            this.Name = "Sale_page";
            this.Size = new System.Drawing.Size(883, 475);
            this.Load += new System.EventHandler(this.Sale_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVcarssale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBcarpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVcarssale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PBcarpicture;
        private System.Windows.Forms.TextBox TBcarid;
        private System.Windows.Forms.TextBox TBfinallprice;
        private System.Windows.Forms.TextBox TBcarprice;
        private System.Windows.Forms.TextBox TBcarmodel;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_clear;
    }
}
