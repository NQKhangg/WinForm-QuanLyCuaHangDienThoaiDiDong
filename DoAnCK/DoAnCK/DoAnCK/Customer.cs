using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_Winform_C_
{
    public partial class Customer : Form
    {
        private string connectionString = "Data Source=DESKTOP-R74P066\\SQLEXPRESS;Initial Catalog=QUANLICUAHANGBANDIENTHOAI;Integrated Security=True";
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter; // Đã sửa tên biến từ adapter thành dataAdapter
        private DataTable dataTable;
        public Customer()
        {
            InitializeComponent();
          
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Khởi tạo đối tượng SqlDataAdapter và DataTable
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();

                    // Thiết lập kết nối cho SqlDataAdapter
                    dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM CUSTOMER", connection);
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

                    // Hiển thị dữ liệu trên DataGridView
                    dataGridView1.DataSource = dataTable;
                    // Thiết lập Font cho Header và các cột
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        column.DefaultCellStyle.Font = new Font("Arial", 11);
                    }
                    // Đổi tên các cột trong DataTable
                    dataTable.Columns["MaKH"].ColumnName = "Mã khách hàng";
                    dataTable.Columns["TenKH"].ColumnName = "Họ tên khách hàng";
                    dataTable.Columns["GioiTinh"].ColumnName = "Giới tính";
                    dataTable.Columns["DiaChi"].ColumnName = "Địa chỉ";
                    dataTable.Columns["SDT"].ColumnName = "Số điện thoại";
                    dataTable.Columns["Email"].ColumnName = "Email";
                    dataTable.Columns["TichDiem"].ColumnName = "Điểm tích lũy";

                    dataGridView1.Columns["Mã khách hàng"].Width = 150;
                    dataGridView1.Columns["Họ tên khách hàng"].Width = 170;
                    dataGridView1.Columns["Giới tính"].Width = 120;
                    dataGridView1.Columns["Địa chỉ"].Width = 200;
                    dataGridView1.Columns["Số điện thoại"].Width = 150;
                    dataGridView1.Columns["Email"].Width = 200;
                    dataGridView1.Columns["Điểm tích lũy"].Width = 120;
                    dataGridView1.Columns["STT"].Width = 50;
                    dataGridView1.Columns["Giới tính"].DisplayIndex = 3;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có ít nhất một dòng được chọn không
            if (dataGridView1.SelectedRows.Count > 0)
            {
              
                // Lấy dòng được chọn đầu tiên
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Lấy giá trị từ nhiều cột
                string MAKH = selectedRow.Cells["Mã khách hàng"].Value.ToString();
                string HOTEN = selectedRow.Cells["Họ tên khách hàng"].Value.ToString();
                string GIOITINH = selectedRow.Cells["Giới tính"].Value.ToString();
                string DIACHI = selectedRow.Cells["Địa chỉ"].Value.ToString();
                string SDT = selectedRow.Cells["Số điện thoại"].Value.ToString();
                string EMAIL = selectedRow.Cells["Email"].Value.ToString();
                string DIEM = selectedRow.Cells["Điểm tích lũy"].Value.ToString();
                // Thêm các cột khác tùy thuộc vào số lượng cột trong DataGridView
                lblMAKH.Text = MAKH;
                lblHOTENKH.Text = HOTEN;
                lblGIOITINH.Text = GIOITINH;
                lblDIACHIKH.Text = DIACHI;
                lblSDT.Text = SDT;
                lblEMAIL.Text = EMAIL;
                lblDIEMTICHLUY.Text = DIEM;
            }
        }

      

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự được nhập vào có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải là số, thì không cho nhập
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            InsertCustomer insertCustomer = new InsertCustomer();
            foreach (Form form in Application.OpenForms)
            {
                // Kiểm tra xem form đang duyệt có phải là InsertEmployee hay không
                if (form.GetType() != typeof(InsertCustomer))
                {
                    // Nếu không phải là InsertEmployee, ẩn form đó
                    form.Hide();
                }
            }
            insertCustomer.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có ít nhất một dòng được chọn không
            if (dataGridView1.SelectedRows.Count > 0)
            {

                // Lấy dòng được chọn đầu tiên
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Lấy giá trị từ nhiều cột
                string MAKH = selectedRow.Cells["Mã khách hàng"].Value.ToString();
                string HOTEN = selectedRow.Cells["Họ tên khách hàng"].Value.ToString();
                string GIOITINH = selectedRow.Cells["Giới tính"].Value.ToString();
                string DIACHI = selectedRow.Cells["Địa chỉ"].Value.ToString();
                string SDT = selectedRow.Cells["Số điện thoại"].Value.ToString();
                string EMAIL = selectedRow.Cells["Email"].Value.ToString();
                string DIEM = selectedRow.Cells["Điểm tích lũy"].Value.ToString();
                // Thêm các cột khác tùy thuộc vào số lượng cột trong DataGridView
                lblMAKH.Text = MAKH;
                lblHOTENKH.Text = HOTEN;
                lblGIOITINH.Text = GIOITINH;
                lblDIACHIKH.Text = DIACHI;
                lblSDT.Text = SDT;
                lblEMAIL.Text = EMAIL;
                lblDIEMTICHLUY.Text = DIEM;
            }
        }
    }
}
