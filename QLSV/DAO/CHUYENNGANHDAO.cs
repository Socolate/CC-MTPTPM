using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV.DTO;

namespace QLSV.DAO
{
    class CHUYENNGANHDAO:DataProvide
    {
        public DataTable getChuyenNganh()
        {       DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_chuyennganh",conn);
            cmd.CommandType=CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themCH(CHUYENGANHDTO CN)
        {
            string query = string.Format("INSERT INTO ChuyenNganh Values ({0},N'{1}',{2})", CN.MACN, CN.TenCN, CN.MAKHOA);
            SqlCommand cmd = new SqlCommand(query,conn);
            conn.Close();
            conn.Open();
            int n =cmd.ExecuteNonQuery();
            if(n>0)
                return true;
            return false;
        }
        public bool xoaCH(CHUYENGANHDTO CN)
        {
            SqlCommand cmd = new SqlCommand("sp_delCN", conn);
                cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maCN", CN.MACN);
            conn.Close();
            conn.Open();
            int n =cmd.ExecuteNonQuery();
            if (n>0) return true;
            return false;
        }
        public bool suaCH(CHUYENGANHDTO CN)
        {
            SqlCommand cmd = new SqlCommand("sp_upCN", conn);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MACN", CN.MACN);
            cmd.Parameters.AddWithValue("@TENCN", CN.TenCN);
            cmd.Parameters.AddWithValue("@MaKhoa", CN.MAKHOA);
            conn.Close();
            conn.Open();
            int n =cmd.ExecuteNonQuery();
            if (n>0) return true;
            return false;
        }
    }
}
