using DoAnCK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_Winform_C_
{
    public partial class frmLogin : Form
    {
        
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        private PrivateFontCollection privateFontCollection;
        DataBase db = new DataBase();
        public frmLogin()
        {
            InitializeComponent();
            this.KeyPreview = true;
            privateFontCollection = new PrivateFontCollection();

            // Danh sách đường dẫn font
            string[] fontPaths = new string[]
            {
                // SVN-Spooky Witchy
                @"Font\CherryBombOne-Regular.ttf",
                @"Font\VNI-Truck.ttf"
            };
            // Thêm từng font vào PrivateFontCollection
            foreach (var fontPath in fontPaths)
            {
                AddFontFromFile(fontPath);
            }

            Font customFont1 = new Font(privateFontCollection.Families[1], 15f, FontStyle.Bold);
            btnExit.Font = customFont1;
            btnLogin.Font = customFont1;
            Font customFont2 = new Font(privateFontCollection.Families[0], 27.75f, FontStyle.Bold);
            label1.Font = customFont2;
        }

        private void AddFontFromFile(string fontFilePath)
        {
            // Đọc dữ liệu font từ tệp tin và chuyển đổi sang mảng byte
            byte[] fontData = System.IO.File.ReadAllBytes(fontFilePath);

            // Khởi tạo con trỏ IntPtr từ mảng byte
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

            // Thêm font vào PrivateFontCollection
            uint dummy = 0;
            AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
            privateFontCollection.AddMemoryFont(fontPtr, fontData.Length);

            // Giải phóng con trỏ
            Marshal.FreeCoTaskMem(fontPtr);
        }

        // Hàm này giúp giải phóng tài nguyên khi ứng dụng đóng
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Giải phóng PrivateFontCollection khi ứng dụng đóng
            privateFontCollection.Dispose();
        }

        private void View_Click(object sender, EventArgs e)
        {
            View.Visible = false;
            Hide.Visible = true;
            txtPassword.PasswordChar = '•';
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            View.Visible = true;
            Hide.Visible = false;
            txtPassword.PasswordChar = '\0';
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            View.Visible = false;
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thực sự muốn thoát khỏi ứng dụng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BanHang bn = new BanHang();
            if (ReadFile(1) || ReadFile(2))
            {
                this.Visible = false;
                bn.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username hoặc Password sai!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        
        public string ReadSpecificLine(string filePath, int lineNumber)
        {
            try
            {
                // Sử dụng StreamReader để đọc dòng cụ thể của file
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Lặp qua từng dòng cho đến khi đến dòng cần truy xuất
                    for (int i = 1; i < lineNumber; i++)
                    {
                        // Đọc và bỏ qua các dòng trước dòng cần truy xuất
                        reader.ReadLine();
                    }

                    // Đọc và trả về dòng cụ thể
                    return reader.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        
        public bool ReadFile(int LineNumber)
        {
            //string filePath = @"Font\Account.txt";

            //using (StreamReader fileReader = new StreamReader(filePath))
            //{
            //    string lineFromFile = ReadSpecificLine(filePath, LineNumber);

            //    if (lineFromFile != null)
            //    {
            //        string[] words = lineFromFile.Split(' ');

            //        if (words.Length >= 2)
            //        {
            //            if (txtUsername.Text == words[0] && txtPassword.Text == words[1] )
            //            {
            //                return true;
            //            }

            //            return false;
            //        }
            //    }
            //}
            string querry = "select * from ADMIN";
            DataTable tb = db.Execute(querry);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                if (tb.Rows[i]["username"].ToString() == txtUsername.Text && tb.Rows[i]["pass"].ToString() == txtPassword.Text)
                {
                    DoAnCK.Properties.Settings.Default.username = txtUsername.Text;
                    DoAnCK.Properties.Settings.Default.pass = txtPassword.Text;
                    DoAnCK.Properties.Settings.Default.Save();
                    DoAnCK.Properties.Settings.Default.ID = tb.Rows[i]["ID"].ToString();
                    DoAnCK.Properties.Settings.Default.HoTen = tb.Rows[i]["HoTen"].ToString();
                    DoAnCK.Properties.Settings.Default.NgaySinh = tb.Rows[i]["NgaySinh"].ToString();
                    DoAnCK.Properties.Settings.Default.GioiTinh = tb.Rows[i]["GioiTinh"].ToString();
                    DoAnCK.Properties.Settings.Default.DiaChi = tb.Rows[i]["DiaChi"].ToString();
                    DoAnCK.Properties.Settings.Default.SDT = tb.Rows[i]["SDT"].ToString();
                    DoAnCK.Properties.Settings.Default.SoThich = tb.Rows[i]["SoThich"].ToString();
                    DoAnCK.Properties.Settings.Default.HinhAnh = tb.Rows[i]["HinhAnh"].ToString();
                    DoAnCK.Properties.Settings.Default.TinhTrang = tb.Rows[i]["TinhTrang"].ToString();
                    DoAnCK.Properties.Settings.Default.DanToc = tb.Rows[i]["DanToc"].ToString();
                    DoAnCK.Properties.Settings.Default.HinhMau = tb.Rows[i]["HinhMau"].ToString();
                    return true;
                }
            }
            return false; 
        }
        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e); 
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
