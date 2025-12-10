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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace QuanLy_Winform_C_
{
    public partial class InsertEmployee : Form
    {
        private string connectionString = "Data Source=DESKTOP-R74P066\\SQLEXPRESS;Initial Catalog=QUANLICUAHANGBANDIENTHOAI;Integrated Security=True;";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        public InsertEmployee()
        {
            InitializeComponent();
        }

        
        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            txtSDT.KeyPress += txtSDT_KeyPress;
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự không phải số từ được nhập vào
            }
        }

        private string GIOITINH;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check())
            {
                GIOITINH = "Nam";

            }
            else
            {
                GIOITINH = "Nữ";
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Tạo câu lệnh SQL INSERT
                    string insertQuery = "INSERT INTO EMPLOYEE (MaNV, HoTenNV, DiaChi, SDT, NgaySinh, Luong, PhuCap, GioiTinh) " +
                                         "VALUES (@MANV, @HOTEN, @DIACHI, @Sdt, @NGAYSINH, @LUONG, @PHUCAP, @GIOITINH)";

                    // Tạo đối tượng SqlCommand
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Truyền giá trị từ controls vào các tham số của câu lệnh SQL
                        command.Parameters.AddWithValue("@MANV", lblMANV.Text); // Giả sử bạn có TextBox để nhập Mã NV
                        command.Parameters.AddWithValue("@HOTEN", txtHOTEN.Text);
                        command.Parameters.AddWithValue("@DIACHI", txtDIACHI.Text);
                        command.Parameters.AddWithValue("@Sdt", txtSDT.Text); // Giả sử bạn có TextBox để nhập Mã NV
                        command.Parameters.AddWithValue("@NGAYSINH", txtNGAYSINH.Text);
                        command.Parameters.AddWithValue("@LUONG", txtLUONG.Text);
                        command.Parameters.AddWithValue("@PHUCAP", txtPHUCAP.Text);
                        command.Parameters.AddWithValue("@GIOITINH", GIOITINH);// Giả sử bạn có TextBox để nhập Mã NV
                        command.ExecuteNonQuery();
                        DialogResult result = MessageBox.Show("Nhân viên đã được thêm vào cơ sở dữ liệu thành công!.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private bool check()
        {
            return radioButtonNam.Checked;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmHomePage homePage = new frmHomePage();
            homePage.Show();
        }

        private void InsertEmployee_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Truy vấn SQL để đếm số lượng nhân viên
                    string query = "SELECT COUNT(*) AS EmployeeCount FROM EMPLOYEE";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Thực thi truy vấn và đọc kết quả
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int employeeCount = Convert.ToInt32(reader["EmployeeCount"]);
                        int k = employeeCount + 1;
                        if (k < 10)
                        {
                            lblMANV.Text = "N000" + k;
                        }
                        else
                        {
                            lblMANV.Text = "N00" + k;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
