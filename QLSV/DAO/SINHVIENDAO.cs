using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV.DTO;

namespace QLSV.DAO
{
    internal class SINHVIENDAO : DataProvide
    {
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("PROC_GETALLSV", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public bool themSinhVien(SinhVienDTO sv)
        {
            string Query = string.Format("INSERT INTO SinhVien values ( N'{0}','{1}',{2},N'{3}',{4},'{5}','{6}')" ,sv.HoTen, sv.NgaySinh, sv.GioiTinh ? 1 : 0, sv.DiaChi, sv.malop, sv.gmail, sv.SDT);
            SqlCommand cm = new SqlCommand();
            cm.CommandText = Query;
            cm.Connection = conn;
            conn.Close();
            conn.Open();
            int n = cm.ExecuteNonQuery();
            if (n > 0)
                return true;
            
            return false;
        }
        public bool suaSinhVien(SinhVienDTO sv)
        {
            string query = string.Format("UPDATE SinhVien SET HoTen=N'{0}',NgaySinh='{1}',GioiTinh={2},DiaChi=N'{3}',MaLop={4},Gmail='{5}',SoDienThoai='{6}'where MaSinhVien='{7}'", sv.HoTen, sv.NgaySinh, sv.GioiTinh ? 1 : 0, sv.DiaChi, sv.malop, sv.gmail, sv.SDT, sv.mssv);
            SqlCommand cm = new SqlCommand();
            cm.CommandText = query;
            cm.Connection = conn;
            conn.Close();
            conn.Open();
            int n = cm.ExecuteNonQuery();
            if (n > 0)
                return true;
            
            return false;
        }
        public bool xoaSinhVien(SinhVienDTO sv)
        {
            SqlCommand cm = new SqlCommand("sp_DelSV",conn);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@MSSV", sv.mssv);
            conn.Close();
            conn.Open();
            int n = cm.ExecuteNonQuery();
            if(n > 0)
                return true;
            
            return false;

        }
    }
}
