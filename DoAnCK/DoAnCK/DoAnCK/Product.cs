using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK
{
     public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }   
        public string Image {  get; set; }
        public string Origin { get; set; }
        public string Brand { get; set; }
        public float Weight {  get; set; }
        public double Price {  get; set; }
        public double Discount { get; set; }  
        public string Color {  get; set; }
        public int Quantity {  get; set; }
        public string Id_TSKT {  get; set; }
        public int DlPin {  get; set; }
        public string CPU {  get; set; }
        public int Ram { get; set; }
        public int BoNhoTrong {  get; set; }
        public string PhienBan {  get; set; }
        public string TinhNangDacBiet {  get; set; }
        public string HeDieuHanh { get; set; }
        public float KichThuocManHinh {  get; set; }
        public string DoPhanGiai {  get; set; }
        public float ChieuDai { get; set; }
        public float ChieuRong { get; set; }
        public float DoDay { get; set; }
    }
}
