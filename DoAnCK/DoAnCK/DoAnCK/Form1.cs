using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Label = System.Reflection.Emit.Label;

namespace QuanLy_Winform_C_
{
    public partial class Form1 : Form
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        private PrivateFontCollection privateFontCollection;
       // C:\Users\baoch\Downloads\DoAnCK(1)\DoAnCK\DoAnCK\Font\CherryBombOne-Regular.ttf
        public Form1()
        {
            InitializeComponent();
            privateFontCollection = new PrivateFontCollection();
            string[] fontPaths = new string[]
            {
    // SVN-Spooky Witchy
                  @"Font\SVN-Spooky Witchy.otf",
    // CHLORINR
                  @"Font\CHLORINR.TTF",
    // TH Death World
                  @"Font\TH Death World.ttf"
    // Thêm các đường dẫn font khác nếu cần
};
            //// Thêm từng font vào PrivateFontCollection
            foreach (var fontPath in fontPaths)
            {
                AddFontFromFile(Path.GetFullPath(fontPath));
               // MessageBox.Show(Path.GetFullPath(fontPath));
            }
            Font customFont1 = new Font(privateFontCollection.Families[2], 21.7499962f, FontStyle.Bold);
            label1.Font = customFont1;
            Font customFont2 = new Font(privateFontCollection.Families[1], 20f, FontStyle.Regular);
            label2.Font = customFont2;
            Font customFont3 = new Font(privateFontCollection.Families[0], 18f, FontStyle.Bold);
            label5.Font = customFont3;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 2;
            if(panel1.Width >= 310)
            {
                timer1.Stop();
                this.Visible = false;
                frmLogin login = new frmLogin();
                login.Show();
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
