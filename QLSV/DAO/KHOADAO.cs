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
    class KHOADAO : DataProvide
    {
        public DataTable getKhoaGet()
        { DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_getkhoa", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;


        }
        public bool themKhoa(KhoaDTO khoa) {
            string query = string.Format("INSERT INTO Khoa values ({0},N'{1}','{2}')", khoa.MAKHOA, khoa.TenKhoa, khoa.GmailKhoa);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();
            conn.Open();
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                return true;
            }
            return false;
        }
        public bool suaKhoa(KhoaDTO khoa)
        {
            string query = string.Format("UPDATE Khoa SET TenKhoa=N'{0}',GmailKhoa='{1}' where MaKhoa={2} ", khoa.TenKhoa, khoa.GmailKhoa, khoa.MAKHOA);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();
            conn.Open();
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                return true;
            }
            return false;
        }
        public bool xoaKhoa(KhoaDTO khoa)
        {
            string query = string.Format("DELETE FROM KHOA WHERE MaKhoa={0}", khoa.MAKHOA);
            SqlCommand cm = new SqlCommand(query, conn);
            conn.Close();
            conn.Open();
            int n = cm.ExecuteNonQuery();
            if (n > 0)
            {
                return true;
            }
            return false;
        }
    }
}
