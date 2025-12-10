using DoAnCK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_Winform_C_
{
    public partial class frmHomePage : Form
    {
        
        public frmHomePage()
        {
           
            InitializeComponent();
            ItemHome.MouseEnter += (sender, e) =>
            {
                customButton1.Visible = true;
            };
            // Sự kiện MouseLeave: Chuột rời khỏi nút
            ItemHome.MouseLeave += (sender, e) =>
            {
                customButton1.Visible = false;
            };

            ItemEmployee.MouseEnter += (sender, e) =>
            {
                customButton2.Visible = true;
            };
            ItemEmployee.MouseLeave += (sender, e) =>
            {
                customButton2.Visible = false;
            };

            ItemCustomer.MouseEnter += (sender, e) =>
            {
                customButton3.Visible = true;
            };
            ItemCustomer.MouseLeave += (sender, e) =>
            {
                customButton3.Visible = false;
            };

            ItemProduct.MouseEnter += (sender, e) =>
            {
                customButton4.Visible = true;
            };
            ItemProduct.MouseLeave += (sender, e) =>
            {
                customButton4.Visible = false;
            };

            ItemBill.MouseEnter += (sender, e) =>
            {
                customButton5.Visible = true;
            };
            ItemBill.MouseLeave += (sender, e) =>
            {
                customButton5.Visible = false;
            };

            ItemLogOut.MouseEnter += (sender, e) =>
            {
                customButton6.Visible = true;
            };
            ItemLogOut.MouseLeave += (sender, e) =>
            {
                customButton6.Visible = false;
            };
            ItemExit.MouseEnter += (sender, e) =>
            {
                customButton7.Visible = true;
            };
            ItemExit.MouseLeave += (sender, e) =>
            {
                customButton7.Visible = false;
            };
        }
        private Form currentFormChild;
        private void OpenFormChild(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            int x = (pnlFrame.Width - childForm.Width) / 2;
            int y = (pnlFrame.Height - childForm.Height) / 2;
            childForm.Location = new Point(x, y);
            childForm.FormBorderStyle = FormBorderStyle.None;
            pnlFrame.Controls.Add(childForm);
            pnlFrame.Tag = childForm;
            childForm.Show();
        }
        private void frmHomePage_Load(object sender, EventArgs e)
        {
            OpenFormChild(new Employee());
            lblTitel.Text = ItemEmployee.Text;
        }

        private void ItemEmployee_Click(object sender, EventArgs e)
        {
            OpenFormChild(new Employee());
            lblTitel.Text = ItemEmployee.Text;
        }

        private void ItemCustomer_Click(object sender, EventArgs e)
        {
            OpenFormChild(new Customer());
            lblTitel.Text = ItemCustomer.Text;
        }

        private void ItemExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void ItemLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất tài khoản ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                frmLogin login = new frmLogin();
                this.Visible = false;
                login.Show();
            }
        }
        private void ItemProduct_Click(object sender, EventArgs e)
        {

            OpenFormChild(new SanPham());
            lblTitel.Text = ItemProduct.Text;
        }

        private void ItemHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BanHang bh = new BanHang();
            bh.Show();
        }
        private void pnlFrame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ItemBill_Click(object sender, EventArgs e)
        {
            OpenFormChild(new Bill());
            lblTitel.Text = ItemBill.Text;
        }
    }
}
