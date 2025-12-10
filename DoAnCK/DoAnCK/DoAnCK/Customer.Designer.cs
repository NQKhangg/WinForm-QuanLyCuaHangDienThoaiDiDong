namespace QuanLy_Winform_C_
{
    partial class Customer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMAKH = new System.Windows.Forms.Label();
            this.lblHOTENKH = new System.Windows.Forms.Label();
            this.lblGIOITINH = new System.Windows.Forms.Label();
            this.lblDIACHIKH = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblEMAIL = new System.Windows.Forms.Label();
            this.customButton1 = new QuanLy_Winform_C_.CustomButton();
            this.lblDIEMTICHLUY = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 370);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(618, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(577, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(575, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Điểm tích lũy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(577, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(575, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(577, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(577, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Họ tên khách hàng";
            // 
            // lblMAKH
            // 
            this.lblMAKH.BackColor = System.Drawing.Color.White;
            this.lblMAKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAKH.Location = new System.Drawing.Point(709, 158);
            this.lblMAKH.Name = "lblMAKH";
            this.lblMAKH.Size = new System.Drawing.Size(169, 23);
            this.lblMAKH.TabIndex = 21;
            this.lblMAKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHOTENKH
            // 
            this.lblHOTENKH.BackColor = System.Drawing.Color.White;
            this.lblHOTENKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHOTENKH.Location = new System.Drawing.Point(709, 198);
            this.lblHOTENKH.Name = "lblHOTENKH";
            this.lblHOTENKH.Size = new System.Drawing.Size(169, 23);
            this.lblHOTENKH.TabIndex = 22;
            this.lblHOTENKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGIOITINH
            // 
            this.lblGIOITINH.AutoEllipsis = true;
            this.lblGIOITINH.BackColor = System.Drawing.Color.White;
            this.lblGIOITINH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGIOITINH.Location = new System.Drawing.Point(709, 238);
            this.lblGIOITINH.Name = "lblGIOITINH";
            this.lblGIOITINH.Size = new System.Drawing.Size(169, 23);
            this.lblGIOITINH.TabIndex = 23;
            this.lblGIOITINH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDIACHIKH
            // 
            this.lblDIACHIKH.BackColor = System.Drawing.Color.White;
            this.lblDIACHIKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDIACHIKH.Location = new System.Drawing.Point(709, 278);
            this.lblDIACHIKH.Name = "lblDIACHIKH";
            this.lblDIACHIKH.Size = new System.Drawing.Size(169, 23);
            this.lblDIACHIKH.TabIndex = 24;
            this.lblDIACHIKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoEllipsis = true;
            this.lblSDT.BackColor = System.Drawing.Color.White;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(709, 318);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(169, 23);
            this.lblSDT.TabIndex = 25;
            this.lblSDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEMAIL
            // 
            this.lblEMAIL.BackColor = System.Drawing.Color.White;
            this.lblEMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEMAIL.Location = new System.Drawing.Point(709, 355);
            this.lblEMAIL.Name = "lblEMAIL";
            this.lblEMAIL.Size = new System.Drawing.Size(169, 23);
            this.lblEMAIL.TabIndex = 26;
            this.lblEMAIL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.customButton1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 10;
            this.customButton1.BorderSize = 0;
            this.customButton1.Enabled = false;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(562, 76);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(328, 370);
            this.customButton1.TabIndex = 6;
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // lblDIEMTICHLUY
            // 
            this.lblDIEMTICHLUY.AutoEllipsis = true;
            this.lblDIEMTICHLUY.BackColor = System.Drawing.Color.White;
            this.lblDIEMTICHLUY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDIEMTICHLUY.Location = new System.Drawing.Point(709, 392);
            this.lblDIEMTICHLUY.Name = "lblDIEMTICHLUY";
            this.lblDIEMTICHLUY.Size = new System.Drawing.Size(169, 23);
            this.lblDIEMTICHLUY.TabIndex = 31;
            this.lblDIEMTICHLUY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDIEMTICHLUY.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(577, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 32;
            this.label10.Text = "Giới tính";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(907, 496);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblDIEMTICHLUY);
            this.Controls.Add(this.lblEMAIL);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblDIACHIKH);
            this.Controls.Add(this.lblGIOITINH);
            this.Controls.Add(this.lblHOTENKH);
            this.Controls.Add(this.lblMAKH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private CustomButton customButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMAKH;
        private System.Windows.Forms.Label lblHOTENKH;
        private System.Windows.Forms.Label lblGIOITINH;
        private System.Windows.Forms.Label lblDIACHIKH;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblEMAIL;
        private System.Windows.Forms.Label lblDIEMTICHLUY;
        private System.Windows.Forms.Label label10;
    }
}