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

    public partial class SanPham : Form
    {
        private string connectionString = "Data Source=DESKTOP-R74P066\\SQLEXPRESS;Initial Catalog=QUANLICUAHANGBANDIENTHOAI;Integrated Security=True;";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        public SanPham()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Insert_TSKT tskt = new Insert_TSKT();
            foreach (Form form in Application.OpenForms)
            {
                // Kiểm tra xem form đang duyệt có phải là InsertEmployee hay không
                if (form.GetType() != typeof(Insert_TSKT))
                {
                    // Nếu không phải là InsertEmployee, ẩn form đó
                    form.Hide();
                }
            }
            tskt.Show();
        }

        private string Id, HinhAnh, NguonGoc, ThuongHieu, MauSac, TrongLuong, SoLuong, Gia, GiamGia, Id_tskt;
        

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            CapNhanSanPham capnhat = new CapNhanSanPham();
            capnhat.id = Id;
            capnhat.nguongoc = NguonGoc;
            capnhat.hinhanh = HinhAnh;
            capnhat.thuonghieu = ThuongHieu;
            capnhat.mausac = MauSac;
            capnhat.trongluong = TrongLuong;
            capnhat.gia = Gia;
            capnhat.giamgia = GiamGia;
            capnhat.soluong = SoLuong;
            capnhat.id_tskt = Id_tskt;
            foreach (Form form in Application.OpenForms)
            {
                // Kiểm tra xem form đang duyệt có phải là InsertEmployee hay không
                if (form.GetType() != typeof(CapNhanSanPham))
                {
                    // Nếu không phải là InsertEmployee, ẩn form đó
                    form.Hide();
                }
            }
            capnhat.Show();
            this.Visible = false;
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    adapter = new SqlDataAdapter();
                    dataTable = new DataTable();
                    adapter.SelectCommand = new SqlCommand("SELECT ID, TenSP, HinhAnh, NguonGoc, ThuongHieu, TrongLuong, Gia, GiamGia, MauSac, SoLuong, ID_TSKT FROM Product", connection);
                    DataColumn serialColumn = new DataColumn("STT", typeof(int));
                    dataTable.Columns.Add(serialColumn);

                    // Đổ dữ liệu từ database vào DataTable
                    adapter.Fill(dataTable);
                    int sttCounter = 1;
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        dataTable.Rows[i]["STT"] = sttCounter++;
                    }
                   
                    dataTable.Columns["ID"].ColumnName = "ID";
                    dataTable.Columns["TenSP"].ColumnName = "Tên sản phẩm";
                    dataTable.Columns["HinhAnh"].ColumnName = "Hình ảnh";
                    dataTable.Columns["NguonGoc"].ColumnName = "Nguồn gốc sản phẩm";
                    dataTable.Columns["ThuongHieu"].ColumnName = "Thương hiệu";
                    dataTable.Columns["TrongLuong"].ColumnName = "Trọng lượng";
                    dataTable.Columns["Gia"].ColumnName = "Giá";
                    dataTable.Columns["GiamGia"].ColumnName = "Giảm giá";
                    dataTable.Columns["MauSac"].ColumnName = "Màu sắc";
                    dataTable.Columns["SoLuong"].ColumnName = "Số lượng";
                    dataTable.Columns["ID_TSKT"].ColumnName = "ID_TSKT";

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns["ID"].Width = 100;
                    dataGridView1.Columns["Tên sản phẩm"].Width = 200;
                    dataGridView1.Columns["Hình ảnh"].Width = 250;
                    dataGridView1.Columns["Nguồn gốc sản phẩm"].Width = 250;
                    dataGridView1.Columns["Thương hiệu"].Width = 150;
                    dataGridView1.Columns["Trọng lượng"].Width = 150;
                    dataGridView1.Columns["Giá"].Width = 120;
                    dataGridView1.Columns["Giảm giá"].Width = 150;
                    dataGridView1.Columns["Màu sắc"].Width = 150;
                    dataGridView1.Columns["Số lượng"].Width = 120;
                    dataGridView1.Columns["ID_TSKT"].Width = 100;
                    dataGridView1.Columns["STT"].Width = 50;

                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                    dataGridView1.Columns["ID"].DefaultCellStyle.Font = new Font("Arial", 11);
                    dataGridView1.Columns["Tên sản phẩm"].DefaultCellStyle.Font = new Font("Arial", 11);
                    dataGridView1.Columns["Hình ảnh"].DefaultCellStyle.Font = new Font("Arial", 11);
                    dataGridView1.Columns["Nguồn gốc sản phẩm"].DefaultCellStyle.Font = new Font("Arial", 11);
                    dataGridView1.Columns["Thương hiệu"].DefaultCellStyle.Font = new Font("Arial", 11);
                    dataGridView1.Columns["Trọng lượng"].DefaultCellStyle.Font = new Font("Arial", 11);
                    dataGridView1.Columns["Giá"].DefaultCellStyle.Font = new Font("Arial", 11);
                    dataGridView1.Columns["Giảm giá"].DefaultCellStyle.Font = new Font("Arial", 11);
                    dataGridView1.Columns["Màu sắc"].DefaultCellStyle.Font = new Font("Arial", 11);
                    dataGridView1.Columns["Số lượng"].DefaultCellStyle.Font = new Font("Arial", 11);
                    dataGridView1.Columns["ID_TSKT"].DefaultCellStyle.Font = new Font("Arial", 11);
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
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Id = selectedRow.Cells["ID"].Value.ToString();
                HinhAnh = selectedRow.Cells["Hình ảnh"].Value.ToString();
                NguonGoc = selectedRow.Cells["Nguồn gốc sản phẩm"].Value.ToString();
                ThuongHieu = selectedRow.Cells["Thương hiệu"].Value.ToString();
                Gia = selectedRow.Cells["Giá"].Value.ToString();
                GiamGia = selectedRow.Cells["Giảm giá"].Value.ToString();
                MauSac = selectedRow.Cells["Màu sắc"].Value.ToString();
                SoLuong = selectedRow.Cells["Số lượng"].Value.ToString();
                TrongLuong = selectedRow.Cells["Trọng lượng"].Value.ToString();
                Id_tskt = selectedRow.Cells["ID_TSKT"].Value.ToString();
                btnCapNhat.Enabled = true;

            }
            else
            {
                btnCapNhat.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int rowIndex = row.Index;
                    string ID_Delete = dataGridView1.Rows[rowIndex].Cells["ID"].Value.ToString();

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            string deleteQuery = "DELETE FROM Product WHERE ID = @Id";

                            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                            {
                                command.Parameters.AddWithValue("@Id", ID_Delete);
                                command.ExecuteNonQuery();
                            }

                            DialogResult result = MessageBox.Show("Bạn muốn xóa sản phẩm ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if(result == DialogResult.OK)
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
