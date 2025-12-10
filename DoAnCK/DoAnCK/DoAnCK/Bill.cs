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
    public partial class Bill : Form
    {
        private string connectionString = "Data Source=DESKTOP-R74P066\\SQLEXPRESS;Initial Catalog=QUANLICUAHANGBANDIENTHOAI;Integrated Security=True;";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    adapter = new SqlDataAdapter();
                    dataTable = new DataTable();
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM BILL", connection);
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
                    dataTable.Columns["MaKH"].ColumnName = "Mã khách hàng";
                    dataTable.Columns["NgayMuaHang"].ColumnName = "Ngày mua hàng";
                    dataTable.Columns["TongTien"].ColumnName = "Tổng tiền";
                    dataTable.Columns["TinhTrang"].ColumnName = "Tình trạng đơn hàng";

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns["ID"].Width = 100;
                    dataGridView1.Columns["Mã khách hàng"].Width = 200;
                    dataGridView1.Columns["Ngày mua hàng"].Width = 150;
                    dataGridView1.Columns["Tổng tiền"].Width = 120;
                    dataGridView1.Columns["Tình trạng đơn hàng"].Width = 250;
                    dataGridView1.Columns["STT"].Width = 50;

                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                    dataGridView1.Columns["ID"].DefaultCellStyle.Font = new Font("Arial", 11);
                    dataGridView1.Columns["Mã khách hàng"].DefaultCellStyle.Font = new Font("Arial", 11);
                    dataGridView1.Columns["Ngày mua hàng"].DefaultCellStyle.Font = new Font("Arial", 11);
                    dataGridView1.Columns["Tổng tiền"].DefaultCellStyle.Font = new Font("Arial", 11);
                    dataGridView1.Columns["Tình trạng đơn hàng"].DefaultCellStyle.Font = new Font("Arial", 11);
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
            // Kiểm tra xem có ít nhất một dòng được chọn không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Lấy giá trị từ nhiều cột
                string ID = selectedRow.Cells["ID"].Value.ToString();
                string MAKH = selectedRow.Cells["Mã khách hàng"].Value.ToString();
                string NGAYMUA = selectedRow.Cells["Ngày mua hàng"].Value.ToString();
                string TONGTIEN = selectedRow.Cells["Tổng tiền"].Value.ToString();
                string TINHTRANG = selectedRow.Cells["Tình trạng đơn hàng"].Value.ToString();
                
                lblID.Text = ID;
                lblMAKH.Text = MAKH;
                lblNGAYMUA.Text = NGAYMUA;
                lblTONGTIEN.Text = TONGTIEN + "VNĐ";
                lblTINHTRANG.Text = TINHTRANG;
                
            }
        }
    }
}
