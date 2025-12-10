using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCK
{
    public partial class ProductUserControl : UserControl
    {
        private TableLayoutPanel panel;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox;
        private Button[] buttons = new Button[2];
        private Label[] labels = new Label[20];
        public Label ThươngHiệu => labels[3];
        public string Ten => labels[1].Text;
        public Image HinhAnh => pictureBox.Image;
        public string Gia => labels[5].Text;
        public string GiamGia => labels[6].Text;
        public Button button_add => buttons[1];
        public ProductUserControl()
        {
            InitializeComponent();
            SetUpLayout();
        }
        
        public void SetUpLayout()
        {
            this.Dock = DockStyle.Fill;
            // tablelayoutpanel
            tableLayoutPanel1 = new TableLayoutPanel();
            //tableLayoutPanel1.Height = 661 ;
            //tableLayoutPanel1.Width = 1500 ;
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            // luu lable
            TableLayoutPanel tb = new TableLayoutPanel();
            tb.Dock = DockStyle.Fill;
            tb.RowCount = 10;
            tb.ColumnCount = 1;
            // Thiết lập kích thước cho mỗi hàng
            for (int i = 0; i < tb.RowCount-1 ; i++)
            {
                tb.RowStyles.Add(new RowStyle(SizeType.Percent,9));
            }
            tb.RowStyles.Add(new RowStyle(SizeType.Percent, 19));
           //tb.RowStyles.Add(new RowStyle(SizeType.Percent, (float)10));
           // tb.RowStyles.Add(new RowStyle(SizeType.Percent, (float)10));
            // picture
            pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Fill;
            TableLayoutPanel tb_picture = new TableLayoutPanel();
            tb_picture.ColumnCount = 1;
            tb_picture.RowCount = 2;
            tb_picture.Dock = DockStyle.Fill;
            tb_picture.RowStyles.Add(new RowStyle(SizeType.Percent, 81));
            tb_picture.RowStyles.Add(new RowStyle(SizeType.Percent, 19));
            tb_picture.Controls.Add(pictureBox, 0, 0);
            //pictureBox.Size = new Size(600, 500);
            // label;
            for (int i = 0; i < 20; i++)
            {
                labels[i] = new Label();
                labels[i].Dock = DockStyle.Fill;
                labels[i].Font = new Font("Arial", 14);
            }
            labels[0].Name = "ID";
            labels[1].Name = "Name";
            labels[2].Name = "Origin";
            labels[3].Name = "Brand";
            labels[4].Name = "Weight";
            labels[5].Name = "Price";
            labels[6].Name = "Discount";
            labels[7].Name = "Color";
            labels[8].Name = "Quantity";
            labels[9].Name = "ID_TSKT";
            labels[10].Name = "Dung lượng Pin";
            labels[11].Name = "CPU";
            labels[12].Name = "Ram";
            labels[13].Name = "Bộ nhớ trong";
            labels[14].Name = "Phiên bản";
            labels[15].Name = "Hệ điều hành";
            labels[16].Name = "Tính năng đặc biệt";
            labels[17].Name = "Kích thước màn hình";
            labels[18].Name = "Độ phân giải";
            labels[19].Name = "Kich thước";
            // button
            for (int i = 0; i < 2; i++)
            {
                buttons[i] = new Button();
                buttons[i].Dock = DockStyle.Fill;
                buttons[i].Font = new Font("Arial", 14);
                buttons[i].ForeColor = Color.White;
                buttons[i].BackColor = Color.Black;
                buttons[i].ImageAlign = ContentAlignment.MiddleCenter;
                //buttons[i].TextAlign = ContentAlignment.MiddleCenter;
                buttons[i].Padding = new Padding(10,0,10,0);
                buttons[i].TextImageRelation = TextImageRelation.ImageBeforeText;
                
            }
            buttons[0].Text = "  Thông số kĩ thuật";
            buttons[0].Image = ResizeImage(Properties.Resources.computer, 32, 32);
            buttons[1].Text = "  Thêm vào giỏ hàng";
            buttons[1].Image = ResizeImage(Properties.Resources.addProduct, 32, 32);
            buttons[0].Click += ProductUserControl_TSKT_Click;
         
            //buttons[0].Click += ProductUserControl_TSKT_Click;
            // them control vao tb;
            for (int i = 0; i < 9; i++)
            {
                tb.Controls.Add(labels[i],0,i);
            }
            tb.Controls.Add(buttons[0], 0, 9);
            tb_picture.Controls.Add(buttons[1], 0, 1);
            // them control vào tablelayoutpanel;
            tableLayoutPanel1.Controls.Add(tb_picture,0,0);
            tableLayoutPanel1.Controls.Add(tb,1,0);
            this.Controls.Add(tableLayoutPanel1);
            //return tableLayoutPanel1;
        }
        private void ProductUserControl_TSKT_Click(object sender, EventArgs e)
        {
            
            // them tskt vao panel
            panel = new TableLayoutPanel();
            panel.BackColor = Color.LightBlue;
            panel.ForeColor = Color.Black;
            //panel.Width = 500;
            //panel.Height = 400;
            //panel.ColumnCount = 1;
            //panel.RowCount = 11;
            //panel.AutoSize = true;
            //Label sol = new Label();
            //sol.Text = "!OK";
            //sol.Font = new Font("Arial",20);
            panel.Dock = DockStyle.Fill;
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
         
            //for (int i = 0; i < 11; i++)
            //{
            //    panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            //}
            Label title = new Label();
            title.Font = new Font("Arial",15,FontStyle.Bold);
            title.ForeColor = Color.Black;
            title.Text = "THÔNG SỐ KĨ THUẬT";
            title.Dock = DockStyle.Fill;
            title.Margin = new Padding(300, 5, 0, 0);
            panel.Controls.Add(title);
            for (int i = 9; i < 20; i++)
            {
                if (i == 9) labels[i].Margin = new Padding(30, 15, 0, 8);
                else labels[i].Margin = new Padding(30, 0, 0, 8);
                labels[i].Dock = DockStyle.Fill;
                labels[i].AutoSize = true;
                panel.Controls.Add(labels[i]);
            }
            TSKT form = new TSKT();
            form.StartPosition = FormStartPosition.CenterParent;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximumSize = new Size(800, 550);
            form.MinimumSize = new Size(800, 550);
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.Text = "Thông số kĩ thuật";
            form.BackColor = Color.LightBlue;
            panel.Location = new Point((form.ClientSize.Width - panel.Width) / 2, (form.ClientSize.Height - panel.Height) / 2);
            //form.Controls.Add(sol);
            form.Controls.Add(panel);
            panel.Margin = new Padding(10, 10, 10, 10);
            form.ShowDialog();
        }
        public void SetProductInfo(Product product)
        {
            
            for (int i = 0; i < 20; i++)
            {
                if (i == 16) continue;
                labels[i].Text = labels[i].Name + ": ";
            }
            //labels[18].Text = "Kích thước: ";
            labels[0].Text += product.Id;
            labels[1].Text += product.Name;
            labels[2].Text += product.Origin;
            labels[3].Text += product.Brand;
            labels[4].Text += product.Weight.ToString();
            labels[5].Text += product.Price.ToString();
            labels[6].Text += ((1 - product.Discount) * 100).ToString() + '%';
            labels[7].Text += product.Color;
            labels[8].Text += product.Quantity.ToString();
            labels[9].Text += product.Id_TSKT;
            labels[10].Text += product.DlPin.ToString() + " mAh";
            labels[11].Text += product.CPU;
            labels[12].Text += product.Ram.ToString() + " GB";
            labels[13].Text += product.BoNhoTrong.ToString() + " GB";
            labels[14].Text += product.PhienBan;
            labels[15].Text += product.HeDieuHanh;
            labels[16].Text += product.TinhNangDacBiet;
            labels[17].Text += product.KichThuocManHinh.ToString() + " inches";
            labels[18].Text += product.DoPhanGiai + " pixels";
            labels[19].Text += String.Format("{0}x{1}x{2}", product.ChieuDai.ToString(), product.ChieuRong.ToString(), product.DoDay.ToString());
            pictureBox.Image = Image.FromFile(product.Image);
            
            int mark = Int32.Parse(product.Id.Substring(1));
            buttons[1].Name = mark.ToString();// đánh dấu;
            string[] chuoi = labels[16].Text.Split(',');
            for (int i = 0; i < chuoi.Length; i++)
            {
                chuoi[i] = "• " + chuoi[i];
                if (i != 0) chuoi[i] = "                                 " + chuoi[i];
            }                 
            labels[16].Text = "Tính năng đặc biệt: " + string.Join("\n", chuoi);

        }
        // thay doi kich thuoc hinh anh;
        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(result))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return result;
        }

    }
}
