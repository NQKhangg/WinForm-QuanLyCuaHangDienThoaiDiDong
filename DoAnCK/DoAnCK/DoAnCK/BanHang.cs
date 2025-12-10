using QuanLy_Winform_C_;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCK
{
    public partial class BanHang : Form
    {
        QuanLiCuaHang ql;
        public List<Product> products = new List<Product>();
        public List<ProductUserControl> product_controls = new List<ProductUserControl>();
        public List<ComboBox> comboBoxes = new List<ComboBox>();
        public List<Label> labels_main = new List<Label>();
        public List<PayUserControl> paylist = new List<PayUserControl>();
        
        public BanHang()
        {
            InitializeComponent();
            ql = new QuanLiCuaHang();
            //ql.ThemNhanVien(82, "nguyen dao", "an tay", "098323", "2/10/2004", 200, 10);
            //ql.SuaNhanVien("N0081", "nguyen hai", "cho an dong", "09321321", "10/2/2001", 10, 4);
            
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            ql.GetProductsFromDataBase(this);
            LoadProductsToTableLayoutPanel();
            //LoadBrandNameToComboBox();
            LoadItemsToComboBox(comboBox1, "ThuongHieu");
            LoadItemsToComboBox(comboBox2, "MauSac");
            LoadItemsToComboBox(comboBox3, "HeDieuHanh");
            LoadItemsToComboBox(comboBox4, "PhienBan");
            AddComboBoxToList();
            //AddLabelToList();
            //LoadColorToComboBox();
        }
        
        private void AddComboBoxToList()
        {
            comboBoxes.Add(comboBox1);
            comboBoxes.Add(comboBox2);
            comboBoxes.Add(comboBox3);
            comboBoxes.Add(comboBox4);
        }
        private void AddLabelToList()
        {
            labels_main.Add(label1);
            labels_main.Add(label2);
            labels_main.Add(label3);
            labels_main.Add(label4);
        }
        private void LoadItemsToComboBox(ComboBox comboBox_slected, string info)
        {
            DataTable tb = ql.GetInFoProducts(info,"");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                comboBox_slected.Items.Add(tb.Rows[i][info].ToString());
            }
        }
        private void LoadProductsToTableLayoutPanel()
        {
            int i;
            for (i = 0; i < products.Count ; i += 4)
            {
                // Tạo TableLayoutPanel
                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.Dock = DockStyle.Top;
                tableLayoutPanel.Height = 600;
                tableLayoutPanel.Width = 1200;
                tableLayoutPanel.ColumnCount = 2;
                tableLayoutPanel.RowCount = 2;
                tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                for (int k = 0; k < tableLayoutPanel.RowCount; k++)
                {
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                }
                int row, col;
                row = 0; col = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (i + j > products.Count - 1) break;
                    if (col == 2) { col = 0; row = 1; }
                    ProductUserControl pr = new ProductUserControl();
                    //TableLayoutPanel tb = pr.SetUpLayout();
                    pr.SetProductInfo(products[i + j]);
                    pr.button_add.Click += Add_Click;
                    tableLayoutPanel.Controls.Add(pr, col, row); // them vao table khi thỏa đk
                    product_controls.Add(pr);
                    ++col;
                }
                panel3.Controls.Add(tableLayoutPanel);
                panel3.Controls.SetChildIndex(tableLayoutPanel, 0);
            }
        }
        
        public void Add_Click(object sender, EventArgs e)
        {
            bool kt = true;
            Button btn = (Button)sender;
            int ma = Int32.Parse(btn.Name);
            string id = ma.ToString().PadLeft(4, '0');
            id = "S" + id;
            foreach(var item in paylist)
            {
                if (item.ID == id)
                {
                    kt = false;
                    break;
                }
            }
            if (kt)
            {
                //MessageBox.Show(products.Count.ToString());
                PayUserControl pays = new PayUserControl();
                //MessageBox.Show((Int32.Parse(btn.Name) - 1).ToString());
                //MessageBox.Show(products[Int32.Parse(btn.Name) - 1].ToString());
                pays.SetInfo(products[Int32.Parse(btn.Name) - 1]);
                //MessageBox.Show(pays.tenpay);
                paylist.Add(pays);
                MessageBox.Show("Đã thêm sản phẩm vào giỏ hàng", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Đã tồn tại sản phẩm trong giỏ hàng", "Thêm sản phẩm",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LocDuLieu()
        {
            panel3.Controls.Clear();
            int i, j;
            for (i = 0; i < products.Count ; i += j)
            {
                // Tạo TableLayoutPanel
                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.Dock = DockStyle.Top;
                tableLayoutPanel.Height = 600;
                tableLayoutPanel.Width = 1200;
                tableLayoutPanel.ColumnCount = 2;
                tableLayoutPanel.RowCount = 2;
                tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                for (int k = 0; k < tableLayoutPanel.RowCount; k++)
                {
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                }
                int row, col;
                row = 0; col = 0;
                j = 0;
                while (row < 2 && col < 2)
                {
                    if (i + j > products.Count -1) break;
                    if (comboBox1.SelectedIndex >= 0)
                    {
                        if (products[i + j].Brand != comboBox1.SelectedItem.ToString()) { j++; continue; }
                    }
                    if (comboBox2.SelectedIndex >= 0)
                    {
                        if (products[i + j].Color != comboBox2.SelectedItem.ToString()) { j++; continue; }
                    }
                    if (comboBox3.SelectedIndex >= 0)
                    {
                        if (products[i + j].HeDieuHanh != comboBox3.SelectedItem.ToString()) { j++; continue; }
                    }
                    if (comboBox4.SelectedIndex >= 0)
                    {
                        if (products[i + j].PhienBan != comboBox4.SelectedItem.ToString()) { j++; continue; }
                    }
                    tableLayoutPanel.Controls.Add(product_controls[i + j], col, row); // them vao table khi thỏa đk
                    ++col;
                    if (col == 2 && row == 0) { col = 0; row = 1; }
                    ++j;
                }
                if (tableLayoutPanel.Controls.Count > 0)
                {
                    panel3.Controls.Add(tableLayoutPanel);
                    panel3.Controls.SetChildIndex(tableLayoutPanel, 0);
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        //List<string> DKLocCB = new List<string>();
        //List<string> DKLocLB = new List<string>();
        private void button2_Click(object sender, EventArgs e)
        {
            //button2.BackColor = Color.Gray;
            bool kt = false;
            foreach (var item in comboBoxes)
            {
                if (item.SelectedIndex >= 0)
                {
                    kt = true;
                    break;
                }
            }
            
            if (kt)
                LocDuLieu();
            //MessageBox.Show(panel3.Controls.Count.ToString());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            product_controls.Clear();
            products.Clear();
            panel3.Controls.Clear();
            comboBox1.SelectedItem = null; comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null; comboBox4.SelectedItem = null;
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            //LoadProductsToTableLayoutPanel();
            ql.GetProductsFromDataBase(this);
            LoadProductsToTableLayoutPanel();
            //LoadBrandNameToComboBox();
            LoadItemsToComboBox(comboBox1, "ThuongHieu");
            LoadItemsToComboBox(comboBox2, "MauSac");
            LoadItemsToComboBox(comboBox3, "HeDieuHanh");
            LoadItemsToComboBox(comboBox4, "PhienBan");
        }
        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }
        private void tảiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }
        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaiKhoan form = new TaiKhoan();
            form.ShowDialog();
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Blue;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;
        }
        public void pictureBox1_Click(object sender, EventArgs e)
        {
            ThanhToan form = new ThanhToan(this);
            //form.Loading();
            form.ShowDialog();
        }
        private void button3_MouseHover_1(object sender, EventArgs e)
        {
            button3.BackColor = Color.Blue;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Yellow;
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmHomePage frm = new frmHomePage();

            //frm.ShowDialog();
            this.Visible = false;
            frmHomePage home = new frmHomePage();
            home.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
        }
    } 
}
