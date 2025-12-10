using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCK
{
    internal class QuanLiCuaHang
    {
        DataBase db;
        public QuanLiCuaHang()
        {
            db = new DataBase();
        }
        // lấy ra số hàng trong bảng nhân viên;
        public int getCountNV()
        {
            string querry = "select count(*) from EMPLOYEE";
            int cnt = db.ExecuteScalar(querry);
            return cnt;
        }
        // them nv;
        public void ThemNhanVien(int count,string hoten,string dc,string sdt,string nsinh,int luong,int phucap)
        {
            string manv = count.ToString();
            manv = 'N' + manv.PadLeft(4, '0');
            string querry = String.Format("insert into EMPLOYEE values (N'{0}',N'{1}',N'{2}',N'{3}','{4}',{5},{6})",manv,hoten,dc,sdt,nsinh,luong,phucap);
            db.ExecuteNonQuerry(querry);
        }
        // xoanv
        public void XoaNhanVien(string manv)
        {
            string querry = String.Format("delete from EMPLOYEE where MaNV = N'{0}'", manv);
            db.ExecuteNonQuerry(querry);
        }
        // sua nhan vien
        public void SuaNhanVien(string manv,string hoten,string dc,string sdt,string nsinh,int luong,int phucap)
        {
            string querry = String.Format("update EMPLOYEE set HoTenNV = N'{0}', DiaChi = N'{1}', SDT = N'{2}', NgaySinh = '{3}', Luong = {4},PhuCap = {5} where MaNV = N'{6}'",
                hoten,dc,sdt,nsinh,luong,phucap,manv);
            db.ExecuteNonQuerry(querry); 
        }
        // 
        public void GetProductsFromDataBase(BanHang f1)
        {
            string querry = "select * from Product P,Product_TSKT PTK where P.ID_TSKT = PTK.ID ";
            DataTable tb = db.Execute(querry);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                Product pr = new Product();
                pr.Id = tb.Rows[i]["ID"].ToString();
                pr.Name = tb.Rows[i]["TenSP"].ToString();
                pr.Image = tb.Rows[i]["HinhAnh"].ToString();
                pr.Origin = tb.Rows[i]["NguonGoc"].ToString();
                pr.Brand = tb.Rows[i]["ThuongHieu"].ToString();
                pr.Weight = float.Parse(tb.Rows[i]["TrongLuong"].ToString());
                pr.Price = double.Parse(tb.Rows[i]["Gia"].ToString());
                pr.Discount = double.Parse(tb.Rows[i]["GiamGia"].ToString());
                pr.Color = tb.Rows[i]["MauSac"].ToString();
                pr.Quantity = Int32.Parse(tb.Rows[i]["SoLuong"].ToString());
                pr.Id_TSKT = tb.Rows[i]["ID_TSKT"].ToString();
                pr.DlPin = Int32.Parse(tb.Rows[i]["DLPin"].ToString());
                pr.CPU = tb.Rows[i]["CPU"].ToString();
                pr.Ram = Int32.Parse(tb.Rows[i]["RAM"].ToString());
                pr.BoNhoTrong = Int32.Parse(tb.Rows[i]["BoNhoTrong"].ToString());
                pr.PhienBan = tb.Rows[i]["PhienBan"].ToString();
                pr.TinhNangDacBiet = tb.Rows[i]["TinhNangDacBiet"].ToString();
                pr.HeDieuHanh = tb.Rows[i]["HeDieuHanh"].ToString();
                pr.KichThuocManHinh = float.Parse(tb.Rows[i]["KichThuocManHinh"].ToString());
                pr.DoPhanGiai = tb.Rows[i]["DoPhanGiai"].ToString();
                pr.ChieuDai = float.Parse(tb.Rows[i]["ChieuDai"].ToString());
                pr.ChieuRong = float.Parse(tb.Rows[i]["ChieuRong"].ToString());
                pr.DoDay = float.Parse(tb.Rows[i]["DoDay"].ToString());
                f1.products.Add(pr);
            }
        }
        // lấy info 
        public DataTable GetInFoProducts(string info,string condition)
        {
            string querry;
            if (condition == "") querry = String.Format("select distinct {0} from Product P,Product_TSKT PTK where P.ID_TSKT = PTK.ID", info);
            else querry = String.Format("select distinct {0} from Product P,Product_TSKT PTK where P.ID_TSKT = PTK.ID", info);
            return db.Execute(querry);
        }
        // LẤY RA DS KHÁCH HÀNG
        public DataTable GetInfoCustomer()
        {
            string querry = "select * from CUSTOMER";
            return db.Execute(querry);
        }
        // them khách hàng;
        public void AddIDCustomer(string ma,string sdt,int td)
        {
            string querry = "insert into CUSTOMER ( MaKH, SDT,TichDiem) values (N'" + ma + "', N'" + sdt  + "', " + td.ToString() +")";
            db.ExecuteNonQuerry(querry);
        }
        public void AddCustomer(string ma,string ten,string dc,string sdt,string email,int tichdiem,string gt)
        {
            string querry = "update CUSTOMER set TenKH = N'" + ten + "', DiaChi = N'" + dc + "', SDT = N'" + sdt + "', Email = N'" + email + "', TichDiem = " + tichdiem.ToString()
                + ", GioiTinh = N'" + gt + "' where MaKh = N'" + ma + "'";
            db.ExecuteNonQuerry(querry);
        }
        // thêm bill;
        public void AddBill(string ma,string makh,DateTime ngaymua,int tongtien,int tinhtrang)
        {
            string querry = String.Format("insert into BILL values (N'{0}',N'{1}','{2}','{3}','{4}')", ma, makh, ngaymua, tongtien, tinhtrang);
            db.ExecuteNonQuerry(querry);
        }
        // them billinfo;
        public void AddBillInfo(string id,string idbill,string idsp,int sl)
        {
            string querry = String.Format("insert into BILLINFO values (N'{0}',N'{1}',N'{2}','{3}')",id,idbill,idsp,sl);
            db.ExecuteNonQuerry(querry);
        }
        // update tichdiem;
        public void UpdateTichDiem(string makh,int diem)
        {
            string querry = "update CUSTOMER set TichDiem = " + diem.ToString() + " where MaKH = N'" + makh + "'";
            db.ExecuteNonQuerry(querry);
        }
        // lấy ra sl bill;
        public int CountBill()
        {
            string querry = "select count(*) from BILL";
            int cnt = (int)db.ExecuteScalar(querry);
            return cnt;
        }
        // update pass cho admin;
        public void UpdateAdmin(string username,string pass)
        {
            string querry = "update ADMIN set pass = N'" + pass + "' where username = N'" + username + "'";
            db.ExecuteNonQuerry(querry);
        }
    }
}
