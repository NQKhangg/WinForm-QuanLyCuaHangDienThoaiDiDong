using QuanLy_Winform_C_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCK
{
    public partial class CapNhanSanPham : Form
    {
        private string connectionString = "Data Source=DESKTOP-R74P066\\SQLEXPRESS;Initial Catalog=QUANLICUAHANGBANDIENTHOAI;Integrated Security=True;";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        public CapNhanSanPham()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmHomePage home = new frmHomePage();
            home.Show();
        }
        public string id, hinhanh, nguongoc, thuonghieu, trongluong, gia, giamgia, soluong, mausac, id_tskt;
       
        private void CapNhanSanPham_Load(object sender, EventArgs e)
        {
            lblID.Text = id;
            txtHinhAnh.Text = hinhanh;
            txtNGUONGOC.Text = nguongoc;
            txtTHUONGHIEU.Text = thuonghieu;
            txtTRONGLUONG.Text = trongluong;
            txtGIA.Text = gia;
            txtGIAMGIA.Text = giamgia;
            txtSOLUONG.Text = soluong;
            txtMAUSAC.Text = mausac;
            txtID_TSKT.Text = id_tskt;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Product SET ID = @Id, HinhAnh = @HINHANH, NguonGoc = @NGUONGOC, ThuongHieu = @THUONGHIEU,  TrongLuong = @TRONGLUONG,  Gia = @GIA,GiamGia = @GIAMGIA,MauSac = @MAUSAC,SoLuong = @SOLUONG,ID_TSKT = @id_tskt  WHERE ID = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", lblID.Text);
                command.Parameters.AddWithValue("@HINHANH", txtHinhAnh.Text);
                command.Parameters.AddWithValue("@NGUONGOC", txtNGUONGOC.Text);
                command.Parameters.AddWithValue("@THUONGHIEU", txtTHUONGHIEU.Text);
                command.Parameters.AddWithValue("@TRONGLUONG", txtTRONGLUONG.Text);
                command.Parameters.AddWithValue("@GIA", txtGIA.Text);
                command.Parameters.AddWithValue("@GIAMGIA", txtGIAMGIA.Text);
                command.Parameters.AddWithValue("@MAUSAC", txtMAUSAC.Text);
                command.Parameters.AddWithValue("@SOLUONG", txtSOLUONG.Text);
                command.Parameters.AddWithValue("@id_tskt", txtID_TSKT.Text);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật sản phẩm thành công!!!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        // You can perform additional actions after successful update
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật sản phẩm không thành công. Kiểm tra lại thông tin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
