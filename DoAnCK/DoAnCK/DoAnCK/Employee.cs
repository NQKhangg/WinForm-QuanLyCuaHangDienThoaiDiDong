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
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLy_Winform_C_
{
    public partial class Employee : Form
    {
        private string connectionString = "Data Source=DESKTOP-R74P066\\SQLEXPRESS;Initial Catalog=QUANLICUAHANGBANDIENTHOAI;Integrated Security=True";
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter; // Đã sửa tên biến từ adapter thành dataAdapter
        private DataTable dataTable;
        public Employee()
        {
            InitializeComponent();
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            txtDIACHI.Visible = false;
            txtSDT.Visible = false;
            txtLUONG.Visible = false;
            txtPHUCAP.Visible = false;
            txtGIOITINH.Visible = false;
            txtNGAYSINH.Visible = false;
            btnEdit.Enabled = false;
            btnSAVE.Enabled = false;
            connection = new SqlConnection(connectionString);
            try
            {


                // Khởi tạo đối tượng SqlDataAdapter và DataTable
                dataAdapter = new SqlDataAdapter();
                dataTable = new DataTable();

                // Thiết lập kết nối cho SqlDataAdapter
                dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM EMPLOYEE", connection);
                DataColumn serialColumn = new DataColumn("STT", typeof(int));

                // Thêm cột vào DataTable
                dataTable.Columns.Add(serialColumn);
                
                // Đổ dữ liệu từ database vào DataTable
                dataAdapter.Fill(dataTable);
                int sttCounter = 1;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataTable.Rows[i]["STT"] = sttCounter++;
                }
                // Các dòng còn lại không thay đổi
                dataTable.Columns["MaNV"].ColumnName = "Mã nhân viên";
                dataTable.Columns["HoTenNV"].ColumnName = "Họ tên nhân viên";
                dataTable.Columns["DiaChi"].ColumnName = "Địa chỉ";
                dataTable.Columns["SDT"].ColumnName = "Số điện thoại";
                dataTable.Columns["NgaySinh"].ColumnName = "Ngày sinh";
                dataTable.Columns["Luong"].ColumnName = "Lương";
                dataTable.Columns["PhuCap"].ColumnName = "Phụ cấp";
                dataTable.Columns["GioiTinh"].ColumnName = "Giới tính";
                // Hiển thị dữ liệu trên DataGridView
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["Giới tính"].DisplayIndex = 3;
                dataGridView1.Columns["Ngày sinh"].DisplayIndex = 3;
                // Đặt độ rộng cho các cột
                dataGridView1.Columns["Mã nhân viên"].Width = 150;
                dataGridView1.Columns["Họ tên nhân viên"].Width = 170;
                dataGridView1.Columns["Địa chỉ"].Width = 200;
                dataGridView1.Columns["Số điện thoại"].Width = 150;
                dataGridView1.Columns["Lương"].Width = 100;
                dataGridView1.Columns["Phụ cấp"].Width = 100;
                dataGridView1.Columns["Giới tính"].Width = 120;
                dataGridView1.Columns["STT"].Width = 50;

                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                dataGridView1.Columns["Mã nhân viên"].DefaultCellStyle.Font = new Font("Arial", 11);
                dataGridView1.Columns["Họ tên nhân viên"].DefaultCellStyle.Font = new Font("Arial", 11);
                dataGridView1.Columns["Địa chỉ"].DefaultCellStyle.Font = new Font("Arial", 11);
                dataGridView1.Columns["Số điện thoại"].DefaultCellStyle.Font = new Font("Arial", 11);
                dataGridView1.Columns["Ngày sinh"].DefaultCellStyle.Font = new Font("Arial", 11);
                dataGridView1.Columns["Lương"].DefaultCellStyle.Font = new Font("Arial", 11);
                dataGridView1.Columns["Phụ cấp"].DefaultCellStyle.Font = new Font("Arial", 11);
                dataGridView1.Columns["Giới tính"].DefaultCellStyle.Font = new Font("Arial", 11);
                dataGridView1.Columns["STT"].DefaultCellStyle.Font = new Font("Arial", 11);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }


        }

      

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lblGIOITINH.Visible = false;
            lblNGAYSINH.Visible = false;
            lblSDT.Visible = false;
            lblLUONG.Visible = false;
            lblPHUCAP.Visible = false;

            txtDIACHI.Visible = true;
            txtSDT.Visible = true;
            txtLUONG.Visible = true;
            txtPHUCAP.Visible = true;
            txtGIOITINH.Visible = true;
            txtNGAYSINH.Visible = true;
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE EMPLOYEE SET MaNV = @MANV, DiaChi = @DIACHI, SDT = @sdt,  NgaySinh = @NGAYSINH, Luong = @LUONG,  PhuCap = @PHUCAP,  GioiTinh = @GIOITINH WHERE MaNV = @MANV";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MANV", lblMANV.Text);
                command.Parameters.AddWithValue("@DIACHI", txtDIACHI.Text);
                command.Parameters.AddWithValue("@sdt", txtSDT.Text);
                command.Parameters.AddWithValue("@NGAYSINH", txtNGAYSINH.Text);
                command.Parameters.AddWithValue("@LUONG", txtLUONG.Text);
                command.Parameters.AddWithValue("@PHUCAP", txtPHUCAP.Text);
                command.Parameters.AddWithValue("@GIOITINH", txtGIOITINH.Text);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee information updated successfully.");
                        // You can perform additional actions after successful update
                    }
                    else
                    {
                        MessageBox.Show("No changes made.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertEmployee insert = new InsertEmployee();
            this.Visible = false;
            frmHomePage home = new frmHomePage();
            foreach (Form form in Application.OpenForms)
            {
                // Kiểm tra xem form đang duyệt có phải là InsertEmployee hay không
                if (form.GetType() != typeof(InsertEmployee))
                {
                    // Nếu không phải là InsertEmployee, ẩn form đó
                    form.Hide();
                }
            }
            insert.Show();
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự không phải số từ được nhập vào
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có ít nhất một dòng được chọn không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                // Lấy dòng được chọn đầu tiên
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Lấy giá trị từ nhiều cột
                string MANV = selectedRow.Cells["Mã nhân viên"].Value.ToString();
                string HOTEN = selectedRow.Cells["Họ tên nhân viên"].Value.ToString();
                string GIOITINH = selectedRow.Cells["Giới tính"].Value.ToString();
                string DIACHI = selectedRow.Cells["Địa chỉ"].Value.ToString();
                string SDT = selectedRow.Cells["Số điện thoại"].Value.ToString();
                string NGAYSINH = selectedRow.Cells["Ngày sinh"].Value.ToString();
                string LUONG = selectedRow.Cells["Lương"].Value.ToString();
                string PHUCAP = selectedRow.Cells["Phụ cấp"].Value.ToString();
                // Thêm các cột khác tùy thuộc vào số lượng cột trong DataGridView
                lblMANV.Text = MANV;
                lblHOTEN.Text = HOTEN;
                lblGIOITINH.Text = GIOITINH;
                lblDIACHI.Text = DIACHI;
                lblSDT.Text = SDT;
                int indexOfSpace = NGAYSINH.IndexOf(' ');
                if (indexOfSpace >= 0)
                {
                    string resultString = NGAYSINH.Substring(0, indexOfSpace);
                    lblNGAYSINH.Text = resultString;
                    txtNGAYSINH.Text = resultString;
                }

                   lblLUONG.Text = LUONG;
                   lblPHUCAP.Text = PHUCAP;

                   txtGIOITINH.Text = GIOITINH;
                   txtDIACHI.Text = DIACHI;
                   txtSDT.Text = SDT;
                   txtLUONG.Text = LUONG;
                   txtPHUCAP.Text = PHUCAP;

            }

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CapNhat_TextChanged(object sender, EventArgs e)
        {
            txtSDT.KeyPress += txtSDT_KeyPress;
            if (txtDIACHI.Text.Length > 0 && txtSDT.Text.Length > 0 && txtLUONG.Text.Length > 0 && (txtGIOITINH.Text == "Nam" || txtGIOITINH.Text == "Nữ"))
            {
                btnSAVE.BackColor = Color.Teal;
                btnSAVE.ForeColor = Color.Black;
                btnSAVE.Enabled = true;
            }
            else
            {
                btnSAVE.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int rowIndex = row.Index;
                    string maNVToDelete = dataGridView1.Rows[rowIndex].Cells["Mã nhân viên"].Value.ToString();

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            string deleteQuery = "DELETE FROM EMPLOYEE WHERE MaNV = @MaNV";

                            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                            {
                                command.Parameters.AddWithValue("@MaNV", maNVToDelete);
                                command.ExecuteNonQuery();
                            }

                            DialogResult result = MessageBox.Show("Bạn muốn xóa nhân viên này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (result == DialogResult.OK)
                            {
                                dataGridView1.Rows.RemoveAt(rowIndex);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.Message);
                        }
                    }
                }

                MessageBox.Show("Dữ liệu đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
