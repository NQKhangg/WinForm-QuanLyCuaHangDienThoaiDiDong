using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCK
{
    public partial class ThanhToan : Form
    {
        BanHang reform;
        int cntBill;
        QuanLiCuaHang ql2 = new QuanLiCuaHang();
        public ThanhToan(BanHang form)
        {
            reform = form;
            InitializeComponent();
            LoadItemToListTxb();
            Loading();
            this.FormClosed += Form5_FormClosed;
            numericUpDown1.Maximum = 0;
            cntBill = ql2.CountBill();
            Load_Icon();
            //Loading();
        }
        private void Load_Icon()
        {
            button1.Image = ResizeImage(Properties.Resources.Pencil_icon, 32, 32);
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.Image = ResizeImage(Properties.Resources.Button_Refresh_icon, 32, 32);
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.Image = ResizeImage(Properties.Resources.cash_icon,32,32);
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            XoaSK();
        }
        private void XoaSK()
        {
            for (int i = 0; i < reform.paylist.Count; i++)
            {
                reform.paylist[i].labelref.TextChanged -= Label_ref_TextChanged;
                reform.paylist[i].numeric_add.Value = 1;
                reform.paylist[i].button_delete.Click -= Button_delete_Click;
            }
        }
        QuanLiCuaHang ql = new QuanLiCuaHang();
        List<TextBox> listtb = new List<TextBox>();
        private void LoadItemToListTxb()
        {
            listtb.Add(textBox1);
            listtb.Add(textBox2);
            listtb.Add(textBox3);
            listtb.Add(textBox4);
            listtb.Add(textBox5);
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            
        }
        double sum = 0;
        public void Loading()
        {
            
            panel8.Controls.Clear();
            sum = 0;
            int i;
            for (i = 0; i < reform.paylist.Count; i += 2)
            {
                // Tạo TableLayoutPanel
                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.Dock = DockStyle.Top;
                tableLayoutPanel.Height = 174;
                tableLayoutPanel.Width = 887;
                tableLayoutPanel.ColumnCount = 1;
                tableLayoutPanel.RowCount = 2;
                //tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
                for (int k = 0; k < tableLayoutPanel.RowCount; k++)
                {
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                }
                int row;
                row = 0;
                for (int j = 0; j < 2; j++)
                {
                    if (i + j >= reform.paylist.Count) break;
                    if (row == 2) break;
                    tableLayoutPanel.Controls.Add(reform.paylist[i + j], 0, row); // them vao table khi thỏa đk
                    sum += reform.paylist[i+j].tien;
                    reform.paylist[i + j].button_delete.Click += Button_delete_Click;
                    reform.paylist[i + j].labelref.TextChanged += Label_ref_TextChanged;
                }
                panel8.Controls.Add(tableLayoutPanel);
                panel8.Controls.SetChildIndex(tableLayoutPanel, 0);
            }
            textBox6.Text = sum.ToString();
        }
        private void Button_delete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Xác nhận xóa sản phẩm này","Xóa sản phẩm",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
            if (r == DialogResult.OK)
            {
                Button btn = (Button)sender;
                TableLayoutPanel tb = btn.Parent as TableLayoutPanel;
                PayUserControl pay = tb.Parent as PayUserControl;
                XoaSK();
                reform.paylist.Remove(pay);
                Loading();
            }
        }
        private void Label_ref_TextChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            sum += Int32.Parse(label.Text.Substring(1));
            textBox6.Text = sum.ToString();
        }
        private void Numeric_add_ValueChanged(object sender, EventArgs e)
        {
            //Label label = (Label)sender;
            //sum += Int32.Parse(label.Text);
            //textBox6.Text = sum.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // txtbox
            foreach(var item in listtb)
            {
                item.Text = "";
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void LoadInfoCustomer(string sdt)
        {
            bool check = false;
            DataTable dt = ql.GetInfoCustomer();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (sdt == dt.Rows[i]["SDT"].ToString())
                {
                    check = true;
                    textBox1.Text = dt.Rows[i]["MaKH"].ToString();
                    textBox1.Enabled = false;
                    textBox2.Text = dt.Rows[i]["TenKH"].ToString();
                    textBox3.Text = dt.Rows[i]["DiaChi"].ToString();
                    textBox4.Text = dt.Rows[i]["Email"].ToString();
                    textBox5.Text = dt.Rows[i]["SDT"].ToString();
                    string gt = dt.Rows[i]["GioiTinh"].ToString();
                    if (gt == "Nam") radioButton1.Checked = true;
                    else radioButton2.Checked = true;
                    string td = dt.Rows[i]["TichDiem"].ToString();
                    label13.Text = td;
                    break;
                }
            }
            if (!check)
            {
                string new_kh = (dt.Rows.Count + 1).ToString();
                new_kh = new_kh.PadLeft(4, '0');
                new_kh = "C" + new_kh;
                textBox1.Text = new_kh;
                textBox1.Enabled = false;
                ql.AddIDCustomer(new_kh,textBox5.Text,0);
            }
        }
        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadInfoCustomer(textBox5.Text);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string gt = "Nam";
                if (radioButton1.Checked == true) gt = "Nam";
                else if (radioButton2.Checked == true) gt = "Nữ";
                ql.AddCustomer(textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text, textBox4.Text, Int32.Parse(label13.Text), gt);
                MessageBox.Show("Cập nhật thông tin thành công", "Cập nhật thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Không thể cập nhật thông tin");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label13_TextChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = decimal.Parse(label13.Text);
        }
        int last = 0;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            sum -= ((int)numericUpDown1.Value - last) * 5000;
            last = (int)numericUpDown1.Value;
            textBox6.Text = sum.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // hien thông báo;
            // insert bill,billinfo;
            try
            {
                DialogResult r = MessageBox.Show("Xác nhận thanh toán cho đơn hàng này", "Thanh toán", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r == DialogResult.OK)
                {
                    AddBill();
                    AddBillInfo();
                    TinhDiem();
                    MessageBox.Show("Thanh toán thành công", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Không thể thanh toán vui lòng kiểm tra lại thông tin", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            // billinfo;
        }
        private void TinhDiem()
        {
            ql.UpdateTichDiem(textBox1.Text, (int)(numericUpDown1.Maximum - numericUpDown1.Value));
            int diem = Int32.Parse(textBox6.Text) / 2000000;
            ql.UpdateTichDiem(textBox1.Text, diem);
        }
        private void AddBill()
        {
            //id;
            string id = (cntBill + 1).ToString().PadLeft(4, '0');
            id = "B" + id;
            DateTime date = DateTime.Now;
            // makh: tbx2;
            //ngaygiaohang: 
            // tongtien: tbx6;
            // tinhtrang: 1
            ql2.AddBill(id, textBox1.Text, date, Int32.Parse(textBox6.Text), 1);
            
        }
        private void AddBillInfo()
        {
            string idbill = (cntBill + 1).ToString().PadLeft(4, '0');
            idbill = "B" + idbill;
            for (int i = 1; i <= reform.paylist.Count; i++)
            {
                string id = i.ToString().PadLeft(4, '0');
                id = "BF" + id;
              
                string idsp = reform.paylist[i - 1].ID;
              
                int sl = (int)(reform.paylist[i - 1].numeric_add.Value);
           
                ql2.AddBillInfo(id, idbill, idsp, sl);
            }
        }
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

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
