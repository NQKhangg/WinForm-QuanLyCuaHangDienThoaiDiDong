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
    public partial class Them_SanPham : Form
    {
        private string connectionString = "Data Source=DESKTOP-R74P066\\SQLEXPRESS;Initial Catalog=QUANLICUAHANGBANDIENTHOAI;Integrated Security=True;";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        public Them_SanPham()
        {
            InitializeComponent();
            LoadId();
        }
        public void LoadId()
        {
            string querry = "select count(*) from Product";
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(querry,connection);
            int cnt = (int)cmd.ExecuteScalar();
            connection.Close();
            string id = (cnt + 1).ToString().PadLeft(4, '0');
            id = "S" + id;
            txtID.Text = id;
            txtID.Enabled = false;
        }
        public string Id;
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmHomePage home = new frmHomePage();
            home.Show();
        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Tạo câu lệnh SQL INSERT
                    string insertQuery = "INSERT INTO Product (ID, TenSP, HinhAnh, NguonGoc, ThuongHieu, TrongLuong, Gia, GiamGia, MauSac, SoLuong, ID_TSKT) " +
                     "VALUES (@Id, @TEN, @HINHANH, @NGUONGOC, @THUONGHIEU, @TRONGLUONG, @GIA, @GIAMGIA, @MAUSAC, @SOLUONG, @id_tskt)";
                    
                    // Tạo đối tượng SqlCommand
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Truyền giá trị từ controls vào các tham số của câu lệnh SQL
                        command.Parameters.AddWithValue("@Id", txtID.Text); // Giả sử bạn có TextBox để nhập Mã NV
                        command.Parameters.AddWithValue("@TEN", txtTEN.Text);
                        command.Parameters.AddWithValue("@HINHANH", txtHinhAnh.Text);
                        command.Parameters.AddWithValue("@NGUONGOC", txtMOTA.Text); // Giả sử bạn có TextBox để nhập Mã NV
                        command.Parameters.AddWithValue("@THUONGHIEU", txtTHUONGHIEU.Text);
                        command.Parameters.AddWithValue("@TRONGLUONG", txtTRONGLUONG.Text);
                        command.Parameters.AddWithValue("@GIA", txtGIA.Text);
                        command.Parameters.AddWithValue("@GIAMGIA", txtGIAMGIA.Text);
                        command.Parameters.AddWithValue("@MAUSAC", txtMAUSAC.Text);
                        command.Parameters.AddWithValue("@SOLUONG", txtSOLUONG.Text);
                        command.Parameters.AddWithValue("@id_tskt", lblID_TSKT.Text);// Giả sử bạn có TextBox để nhập Mã NV
                        command.ExecuteNonQuery();
                        MessageBox.Show("Sản phẩm đã được thêm vào cơ sở dữ liệu thành công!.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void Them_SanPham_Load(object sender, EventArgs e)
        {
            lblID_TSKT.Text = Id;
            
        }
    }
}
