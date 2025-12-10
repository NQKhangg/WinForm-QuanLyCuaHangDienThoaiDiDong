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
    public partial class InsertCustomer : Form
    {
        public InsertCustomer()
        {
            InitializeComponent();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            frmHomePage homePage = new frmHomePage();
            homePage.Show();
        }
    }
}
