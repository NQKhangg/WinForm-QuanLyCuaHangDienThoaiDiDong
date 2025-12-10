using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCK
{
    public partial class TaiKhoan : Form
    {
        QuanLiCuaHang ql;
        public TaiKhoan()
        {
            ql = new QuanLiCuaHang();
            InitializeComponent();
            LoadInfoTaiKhoan();
            LoadInfoFrofile();
        }
        private void LoadInfoFrofile()
        {
            pictureBox1.Image = Image.FromFile(DoAnCK.Properties.Settings.Default.HinhAnh);
            Label[] labels = new Label[8];
            for (int i = 0; i < 8; i++)
            {
                labels[i] = new Label();
                labels[i].Dock = DockStyle.Fill;
                labels[i].Font = new Font("Arial", 11);
            }
            labels[0].Text = "ID: "  + DoAnCK.Properties.Settings.Default.ID;
            labels[1].Text = "Họ và Tên: " + DoAnCK.Properties.Settings.Default.HoTen;
            labels[2].Text = "Ngày Sinh: " + DoAnCK.Properties.Settings.Default.NgaySinh;
            labels[3].Text = "Giới tính: " + DoAnCK.Properties.Settings.Default.GioiTinh;
            labels[4].Text = "Số điện thoại: " + DoAnCK.Properties.Settings.Default.SDT;
            labels[5].Text = "Tình trạng hôn nhân: " + DoAnCK.Properties.Settings.Default.TinhTrang;
            labels[6].Text = "Dân tộc: " + DoAnCK.Properties.Settings.Default.DanToc;
            labels[7].Text = "Địa chỉ: " + DoAnCK.Properties.Settings.Default.DiaChi;
            for (int i = 0; i < 8; i++)
            {
                tableLayoutPanel3.Controls.Add(labels[i]);
            }
            //
            Label st = new Label();
            st.Dock = DockStyle.Fill;
            st.Text = "Sở thích: " + "\n";
            st.Font = new Font("Arial", 11);
            string[] str_st = DoAnCK.Properties.Settings.Default.SoThich.Split(',');
            for (int i = 0; i < str_st.Length; i++)
            {
                str_st[i] = "• " + str_st[i];
            }
            string str_join = string.Join("\n", str_st);
            st.Text += str_join;
            Label hm = new Label();
            hm.Dock = DockStyle.Fill;
            hm.Text = "Hình mẫu lý tưởng: " + "\n";
            hm.Font = new Font("Arial", 11);
            string[] str_hm = DoAnCK.Properties.Settings.Default.HinhMau.Split(',');
            for (int i = 0; i < str_hm.Length; i++)
            {
                str_hm[i] = "• " + str_hm[i];
            }
            string strhm_join = string.Join("\n", str_hm);
            hm.Text += strhm_join;
            tableLayoutPanel2.Controls.Add(st,0,0);
            tableLayoutPanel2.Controls.Add(hm, 1, 0);
           }
        private void LoadInfoTaiKhoan()
        {
            textBox1.Text = DoAnCK.Properties.Settings.Default.username;
            textBox1.ReadOnly = true;
            textBox2.Text = DoAnCK.Properties.Settings.Default.pass;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox3.Text))
            {
                if (textBox3.Text == textBox4.Text)
                {
                    // front;
                    DoAnCK.Properties.Settings.Default.pass = textBox3.Text;
                    MessageBox.Show("Cập nhật thông tin thành công", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    // back;
                    ql.UpdateAdmin(textBox1.Text, textBox3.Text);
                }
                else MessageBox.Show("Nhập lại mật khẩu mới không chính xác","Lưu thông tin",MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                MessageBox.Show("Thông tin không đầy đủ","Lưu thông tin",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox4.Text = "";
            textBox3.Focus();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
