using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.DTO;

namespace QLSV.DAO
{
    class MONHOCDAO:DataProvide
    {
        public DataTable getMonHoc()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_getmonhoc",conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;

        }
        public bool themMH(MONHOCDTO MHDTO)
        {
            string query = string.Format("INSERT INTO MonHoc values ({0},N'{1}',{2},{3},{4})",MHDTO.MaMH,MHDTO.TenMH,MHDTO.TinChi,MHDTO.HocKy,MHDTO.ChuyenNganh);
            SqlCommand cmd = new SqlCommand(query,conn);
            conn.Close();
            conn.Open();
            int n= cmd.ExecuteNonQuery();
            if(n>0)
            {
                return true;
                
            }
            return false;
        }
        public bool suaMH(MONHOCDTO MHDTO)
        {
            SqlCommand cmd = new SqlCommand("sp_editMH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAMH",MHDTO.MaMH);
            cmd.Parameters.AddWithValue("@TENMH",MHDTO.TenMH);
            cmd.Parameters.AddWithValue("@TinChi", MHDTO.TinChi);
            cmd.Parameters.AddWithValue("@HocKy",MHDTO.HocKy);
            cmd.Parameters.AddWithValue("@MACN",MHDTO.ChuyenNganh);
            conn.Close();
            conn.Open();
            int n= cmd.ExecuteNonQuery();
            if( n>0) { return true; } 
            return false;
        }
        public bool xoaMH(MONHOCDTO MHDTO)
        {
            SqlCommand cmd = new SqlCommand("sp_delMH",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAMH", MHDTO.MaMH);
            conn.Close();
            conn.Open();
            int n= cmd.ExecuteNonQuery();
            if ( n>0 ) { return true; } return false;
        }
    }
}
