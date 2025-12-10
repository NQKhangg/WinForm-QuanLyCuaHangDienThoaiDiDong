namespace QuanLy_Winform_C_
{
    partial class Employee
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtLUONG = new System.Windows.Forms.TextBox();
            this.txtPHUCAP = new System.Windows.Forms.TextBox();
            this.lblMANV = new System.Windows.Forms.Label();
            this.lblHOTEN = new System.Windows.Forms.Label();
            this.lblDIACHI = new System.Windows.Forms.Label();
            this.lblGIOITINH = new System.Windows.Forms.Label();
            this.lblNGAYSINH = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblLUONG = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPHUCAP = new System.Windows.Forms.Label();
            this.txtGIOITINH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNGAYSINH = new System.Windows.Forms.TextBox();
            this.customButton1 = new QuanLy_Winform_C_.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(31, 426);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(165, 56);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Thêm nhân viên";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.Image = global::DoAnCK.Properties.Resources.add_user;
            this.pictureBox1.Location = new System.Drawing.Point(170, 441);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox4.Image = global::DoAnCK.Properties.Resources.delete;
            this.pictureBox4.Location = new System.Drawing.Point(340, 441);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gray;
            this.pictureBox3.Image = global::DoAnCK.Properties.Resources.user_avatar;
            this.pictureBox3.Location = new System.Drawing.Point(510, 441);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(216, 426);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 56);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa nhân viên";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gray;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(382, 426);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(160, 56);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa nhân viên";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(616, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(594, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(594, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Họ tên nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(594, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(594, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(594, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lương";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(594, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Phụ cấp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(594, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Ngày sinh";
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackColor = System.Drawing.Color.Teal;
            this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.ForeColor = System.Drawing.Color.Black;
            this.btnSAVE.Location = new System.Drawing.Point(694, 384);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(99, 38);
            this.btnSAVE.TabIndex = 22;
            this.btnSAVE.Text = "Lưu";
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDIACHI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDIACHI.Location = new System.Drawing.Point(713, 220);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(155, 22);
            this.txtDIACHI.TabIndex = 25;
            this.txtDIACHI.TextChanged += new System.EventHandler(this.CapNhat_TextChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(713, 250);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(155, 22);
            this.txtSDT.TabIndex = 24;
            this.txtSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSDT.TextChanged += new System.EventHandler(this.CapNhat_TextChanged);
            // 
            // txtLUONG
            // 
            this.txtLUONG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLUONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLUONG.Location = new System.Drawing.Point(713, 310);
            this.txtLUONG.Name = "txtLUONG";
            this.txtLUONG.Size = new System.Drawing.Size(155, 22);
            this.txtLUONG.TabIndex = 24;
            this.txtLUONG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLUONG.TextChanged += new System.EventHandler(this.CapNhat_TextChanged);
            // 
            // txtPHUCAP
            // 
            this.txtPHUCAP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPHUCAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPHUCAP.Location = new System.Drawing.Point(713, 340);
            this.txtPHUCAP.Name = "txtPHUCAP";
            this.txtPHUCAP.Size = new System.Drawing.Size(155, 22);
            this.txtPHUCAP.TabIndex = 24;
            this.txtPHUCAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPHUCAP.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // lblMANV
            // 
            this.lblMANV.BackColor = System.Drawing.Color.White;
            this.lblMANV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMANV.Location = new System.Drawing.Point(713, 130);
            this.lblMANV.Name = "lblMANV";
            this.lblMANV.Size = new System.Drawing.Size(155, 22);
            this.lblMANV.TabIndex = 1;
            this.lblMANV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHOTEN
            // 
            this.lblHOTEN.BackColor = System.Drawing.Color.White;
            this.lblHOTEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHOTEN.Location = new System.Drawing.Point(713, 160);
            this.lblHOTEN.Name = "lblHOTEN";
            this.lblHOTEN.Size = new System.Drawing.Size(155, 22);
            this.lblHOTEN.TabIndex = 2;
            this.lblHOTEN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDIACHI
            // 
            this.lblDIACHI.BackColor = System.Drawing.Color.White;
            this.lblDIACHI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDIACHI.Location = new System.Drawing.Point(713, 220);
            this.lblDIACHI.Name = "lblDIACHI";
            this.lblDIACHI.Size = new System.Drawing.Size(155, 22);
            this.lblDIACHI.TabIndex = 2;
            this.lblDIACHI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGIOITINH
            // 
            this.lblGIOITINH.AutoEllipsis = true;
            this.lblGIOITINH.BackColor = System.Drawing.Color.White;
            this.lblGIOITINH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGIOITINH.Location = new System.Drawing.Point(713, 190);
            this.lblGIOITINH.Name = "lblGIOITINH";
            this.lblGIOITINH.Size = new System.Drawing.Size(155, 22);
            this.lblGIOITINH.TabIndex = 2;
            this.lblGIOITINH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNGAYSINH
            // 
            this.lblNGAYSINH.BackColor = System.Drawing.Color.White;
            this.lblNGAYSINH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNGAYSINH.Location = new System.Drawing.Point(713, 250);
            this.lblNGAYSINH.Name = "lblNGAYSINH";
            this.lblNGAYSINH.Size = new System.Drawing.Size(155, 22);
            this.lblNGAYSINH.TabIndex = 2;
            this.lblNGAYSINH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSDT
            // 
            this.lblSDT.BackColor = System.Drawing.Color.White;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(713, 278);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(155, 22);
            this.lblSDT.TabIndex = 2;
            this.lblSDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLUONG
            // 
            this.lblLUONG.BackColor = System.Drawing.Color.White;
            this.lblLUONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLUONG.Location = new System.Drawing.Point(713, 310);
            this.lblLUONG.Name = "lblLUONG";
            this.lblLUONG.Size = new System.Drawing.Size(155, 22);
            this.lblLUONG.TabIndex = 2;
            this.lblLUONG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(511, 330);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // lblPHUCAP
            // 
            this.lblPHUCAP.BackColor = System.Drawing.Color.White;
            this.lblPHUCAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPHUCAP.Location = new System.Drawing.Point(713, 340);
            this.lblPHUCAP.Name = "lblPHUCAP";
            this.lblPHUCAP.Size = new System.Drawing.Size(155, 22);
            this.lblPHUCAP.TabIndex = 28;
            this.lblPHUCAP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGIOITINH
            // 
            this.txtGIOITINH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGIOITINH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGIOITINH.Location = new System.Drawing.Point(713, 190);
            this.txtGIOITINH.Name = "txtGIOITINH";
            this.txtGIOITINH.Size = new System.Drawing.Size(155, 22);
            this.txtGIOITINH.TabIndex = 29;
            this.txtGIOITINH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGIOITINH.TextChanged += new System.EventHandler(this.CapNhat_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(594, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "Giới tính";
            // 
            // txtNGAYSINH
            // 
            this.txtNGAYSINH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNGAYSINH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNGAYSINH.Location = new System.Drawing.Point(713, 278);
            this.txtNGAYSINH.Name = "txtNGAYSINH";
            this.txtNGAYSINH.Size = new System.Drawing.Size(155, 22);
            this.txtNGAYSINH.TabIndex = 31;
            this.txtNGAYSINH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.customButton1.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 20;
            this.customButton1.BorderSize = 0;
            this.customButton1.Enabled = false;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.Black;
            this.customButton1.Location = new System.Drawing.Point(563, 49);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(322, 393);
            this.customButton1.TabIndex = 0;
            this.customButton1.TextColor = System.Drawing.Color.Black;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(907, 496);
            this.Controls.Add(this.txtNGAYSINH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtGIOITINH);
            this.Controls.Add(this.lblPHUCAP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblLUONG);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblNGAYSINH);
            this.Controls.Add(this.lblGIOITINH);
            this.Controls.Add(this.lblDIACHI);
            this.Controls.Add(this.lblHOTEN);
            this.Controls.Add(this.lblMANV);
            this.Controls.Add(this.txtPHUCAP);
            this.Controls.Add(this.txtLUONG);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDIACHI);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.customButton1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomButton customButton1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.TextBox txtDIACHI;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtLUONG;
        private System.Windows.Forms.TextBox txtPHUCAP;
        private System.Windows.Forms.Label lblMANV;
        private System.Windows.Forms.Label lblHOTEN;
        private System.Windows.Forms.Label lblDIACHI;
        private System.Windows.Forms.Label lblGIOITINH;
        private System.Windows.Forms.Label lblNGAYSINH;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblLUONG;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPHUCAP;
        private System.Windows.Forms.TextBox txtGIOITINH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNGAYSINH;
    }
}