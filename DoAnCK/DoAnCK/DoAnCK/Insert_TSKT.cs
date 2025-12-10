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

namespace DoAnCK
{
    public partial class Insert_TSKT : Form
    {
        private string connectionString = "Data Source=DESKTOP-R74P066\\SQLEXPRESS;Initial Catalog=QUANLICUAHANGBANDIENTHOAI;Integrated Security=True;";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        public Insert_TSKT()
        {
            InitializeComponent();
        }

        private void Insert_TSKT_Load(object sender, EventArgs e)
        {

        }

        private string id;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtDLPIN.Enabled == false)
            {
                Them_SanPham them = new Them_SanPham();
                them.Id = txtID.Text;
                them.Show();
                this.Visible = false;

            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        // Tạo câu lệnh SQL INSERT
                        string insertQuery = "INSERT INTO Product_TSKT (ID, DLPin, CPU, RAM, BoNhoTrong, PhienBan, TinhNangDacBiet, HeDieuHanh, KichThuocManHinh, DoPhanGiai,  ChieuDai, ChieuRong, DoDay) " +
                         "VALUES (@Id, @DLPIN, @CPU, @RAM, @BONHO, @PHIENBAN, @TINHNANG, @HDH, @KICHTHUOC, @DOPHANGIAI, @CHIEUDAI, @CHIEURONG, @DODAY)";

                        // Tạo đối tượng SqlCommand
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            // Truyền giá trị từ controls vào các tham số của câu lệnh SQL
                            command.Parameters.AddWithValue("@ID", txtID.Text); // Giả sử bạn có TextBox để nhập Mã NV
                            command.Parameters.AddWithValue("@DLPIN", txtDLPIN.Text);
                            command.Parameters.AddWithValue("@CPU", txtCPU.Text);
                            command.Parameters.AddWithValue("@RAM", txtRAM.Text); // Giả sử bạn có TextBox để nhập Mã NV
                            command.Parameters.AddWithValue("@BONHO", txtBONHOTRONG.Text);
                            command.Parameters.AddWithValue("@PHIENBAN", txtPHIENBAN.Text);
                            command.Parameters.AddWithValue("@TINHNANG", txtTINHNANG.Text);
                            command.Parameters.AddWithValue("@HDH", txtHDH.Text);
                            command.Parameters.AddWithValue("@KICHTHUOC", txtKICHTHUOC.Text);
                            command.Parameters.AddWithValue("@DOPHANGIAI", txtDPGiai.Text);
                            command.Parameters.AddWithValue("@CHIEUDAI", txtCHIEUDAI.Text);
                            command.Parameters.AddWithValue("@CHIEURONG", txtCHIEURONG.Text);
                            command.Parameters.AddWithValue("@DODAY", txtDODAY.Text);// Giả sử bạn có TextBox để nhập Mã NV
                            command.ExecuteNonQuery();
                            Them_SanPham them = new Them_SanPham();
                            them.Id = txtID.Text;
                            them.Show();
                            this.Visible = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }
        private void txtID_Enter(object sender, EventArgs e)
        {
            
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SanPham sp = new SanPham();
            sp.Show();
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    string querry = "select * from Product_TSKT where ID = N'" + txtID.Text + "'";
                    SqlConnection connect = new SqlConnection(connectionString);
                    SqlDataAdapter adapter = new SqlDataAdapter(querry, connect);
                    DataSet set = new DataSet();
                    adapter.Fill(set);
                    DataTable tb = set.Tables[0];
                    if (tb.Rows.Count == 1)
                    {
                        txtDLPIN.Text = tb.Rows[0]["DLPin"].ToString();
                        txtDLPIN.Enabled = false;
                        txtCPU.Text = tb.Rows[0]["CPU"].ToString();
                        txtCPU.Enabled = false;
                        txtRAM.Text = tb.Rows[0]["RAM"].ToString();
                        txtRAM.Enabled = false;
                        txtBONHOTRONG.Text = tb.Rows[0]["BoNhoTrong"].ToString();
                        txtBONHOTRONG.Enabled = false;
                        txtPHIENBAN.Text = tb.Rows[0]["PhienBan"].ToString();
                        txtPHIENBAN.Enabled = false;
                        txtTINHNANG.Text = tb.Rows[0]["TinhNangDacBiet"].ToString();
                        txtTINHNANG.Enabled = false;
                        txtHDH.Text = tb.Rows[0]["HeDieuHanh"].ToString();
                        txtHDH.Enabled = false;
                        txtKICHTHUOC.Text = tb.Rows[0]["KichThuocManHinh"].ToString();
                        txtKICHTHUOC.Enabled = false;
                        txtDPGiai.Text = tb.Rows[0]["DoPhanGiai"].ToString();
                        txtDPGiai.Enabled = false;
                        txtCHIEUDAI.Text = tb.Rows[0]["ChieuDai"].ToString();
                        txtCHIEUDAI.Enabled = false;
                        txtCHIEURONG.Text = tb.Rows[0]["ChieuRong"].ToString();
                        txtCHIEURONG.Enabled = false;
                        txtDODAY.Text = tb.Rows[0]["DoDay"].ToString();
                        txtDODAY.Enabled = false;
                    }
                    else
                    {
                        txtDLPIN.Text = "";
                        txtDLPIN.Enabled = true;
                        txtCPU.Text = "";
                        txtCPU.Enabled = true;
                        txtRAM.Text = "";
                        txtRAM.Enabled = true;
                        txtBONHOTRONG.Text = "";
                        txtBONHOTRONG.Enabled = true;
                        txtPHIENBAN.Text = "";
                        txtPHIENBAN.Enabled = true;
                        txtTINHNANG.Text = "";
                        txtTINHNANG.Enabled = true;
                        txtHDH.Text = "";
                        txtHDH.Enabled = true;
                        txtKICHTHUOC.Text = "";
                        txtKICHTHUOC.Enabled = true;
                        txtDPGiai.Text = "";
                        txtDPGiai.Enabled = true;
                        txtCHIEUDAI.Text = "";
                        txtCHIEUDAI.Enabled = true;
                        txtCHIEURONG.Text = "";
                        txtCHIEURONG.Enabled = true;
                        txtDODAY.Text = "";
                        txtDODAY.Enabled = true;
                    }
                }
            }
        }
    }
}
