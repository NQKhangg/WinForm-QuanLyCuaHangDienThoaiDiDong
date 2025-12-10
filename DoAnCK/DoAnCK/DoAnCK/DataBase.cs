using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK
{
    internal class DataBase
    {
        public SqlConnection connection;
        SqlDataAdapter adapter;
        DataSet set;
        public DataBase()
        {
            string strconnect = "Data Source=DESKTOP-R74P066\\SQLEXPRESS;Initial Catalog=QUANLICUAHANGBANDIENTHOAI;Integrated Security=True";
            connection = new SqlConnection(strconnect); // ket noi;
        }
        // pt thực hiện câu lệnh truy vấn dữ liệu;
        public DataTable Execute(string querry)
        {
            adapter = new SqlDataAdapter(querry, connection);
            set = new DataSet();
            adapter.Fill(set);
            return set.Tables[0];
        }
        // pt thực hiện thêm, xóa, sửa;
        public void ExecuteNonQuerry(string querry)
        {
            SqlCommand cmd = new SqlCommand(querry, connection);
            connection.Open();   // mở kết nối
            cmd.ExecuteNonQuery();  // 
            connection.Close(); // đóng kết nối
        }
        public int ExecuteScalar(string querry)
        {
            SqlCommand cmd = new SqlCommand(querry, connection);
            connection.Open();   // mở kết nối
            int count = (int)cmd.ExecuteScalar();  // 
            connection.Close(); // đóng kết nối
            return count;
        }
        public SqlDataReader SqlDataReader(string querry)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(querry, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            
            return reader;
        }
    }
}
