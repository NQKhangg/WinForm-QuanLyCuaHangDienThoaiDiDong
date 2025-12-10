using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCK
{
    public partial class PayUserControl : UserControl
    {
        PictureBox pictureBox1;
        Label[] labels;
        Button button;
        NumericUpDown numeric;
        public string ID;
        public Button button_delete => button;
        public string tenpay => labels[0].Text;
        public NumericUpDown numeric_add => numeric;
        //Dictionary<double, NumericUpDown> tien = new Dictionary<double, NumericUpDown>(tien1, numeric);
        //public double tien => tien1;
        public double tien;
        public Label labelref = new Label();
        public Label label_ref => labelref;
        public PayUserControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            SetUpLayout();
        }
        public void SetUpLayout()
        {
            pictureBox1 = new PictureBox();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Dock = DockStyle.Fill;
            labels = new Label[3];
            for (int i = 0; i < 3; i++)
            {

                labels[i] = new Label();
                labels[i].Dock = DockStyle.Fill;
                labels[i].Font = new Font("Arial", 11);
                labels[i].Padding = new Padding(0, 2, 0, 0);
            }
            button = new Button();
            button.Font = new Font("Arial", 11);
            button.BackColor = Color.Coral;
            //button.Dock = DockStyle.Fill;
            numeric = new NumericUpDown();
            numeric.DecimalPlaces = 0;
            numeric.Minimum = 1;
            pre_label = 1;
            numeric.ValueChanged += Numeric_ValueChanged;
            tableLayoutPanel1.Controls.Add(pictureBox1,0,0);
            tableLayoutPanel1.Controls.Add(labels[0],1,0);
            tableLayoutPanel1.Controls.Add(labels[1],2,0);
            tableLayoutPanel1.Controls.Add(labels[2], 3, 0);
            tableLayoutPanel1.Controls.Add(button,5,0);
            tableLayoutPanel1.Controls.Add(numeric, 4, 0);
        }
        int pre_label = 1;
        private void Numeric_ValueChanged(object sender, EventArgs e)
        {
            int cur_label = (int)numeric.Value;
            labelref.Text = numeric.Value.ToString() + ((cur_label - pre_label) * tien).ToString();
            pre_label = cur_label;
        }
        public void SetInfo(Product pu) 
        {
            ID = pu.Id;
            pictureBox1.Image = Image.FromFile(pu.Image);
            labels[0].Text = pu.Name + " (" + pu.Color.ToString() + ")";
            labels[1].Text = pu.Price.ToString() + " VNĐ";
            tien = pu.Price * pu.Discount;
            labels[2].Text = (pu.Price * pu.Discount).ToString() + " VNĐ";
            numeric.Value = 1;
            button.Text = "Xóa";
        }
    }
}
