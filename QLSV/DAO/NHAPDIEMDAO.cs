using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV.BUS;
using QLSV.DTO;

namespace QLSV.DAO
{
    class NHAPDIEMDAO : DataProvide
    {
        public DataTable getDiem()
        {   DataTable dt = new DataTable();
            SqlCommand cmd= new SqlCommand("sp_getNhapDiem",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;

        }
        public bool nhapDiem(NhapDiemDTO NDIEM)
        {
            SqlCommand cmd = new SqlCommand("sp_nhapDiem", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MASV",NDIEM.MASV);
            cmd.Parameters.AddWithValue("@MAMH",NDIEM.MAMH);
            cmd.Parameters.AddWithValue("@DCC",NDIEM.DIEMCC);
            cmd.Parameters.AddWithValue("@DTHI", NDIEM.DIEMTHI);
            cmd.Parameters.AddWithValue("@DTBKT",NDIEM.DIEMTBK);
            conn.Close();
            conn.Open();
            int n=cmd.ExecuteNonQuery();
            if(n>0)
            {
                return true;
            }    
            return false;
        }

        public bool suaDiem(NhapDiemDTO NDIEM)
        {
            SqlCommand cmd = new SqlCommand("sp_suaDiem", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MASV", NDIEM.MASV);
            cmd.Parameters.AddWithValue("@MAMH", NDIEM.MAMH);
            cmd.Parameters.AddWithValue("@DCC", NDIEM.DIEMCC);
            cmd.Parameters.AddWithValue("@DTHI", NDIEM.DIEMTHI);
            cmd.Parameters.AddWithValue("@DTBKT", NDIEM.DIEMTBK);
            conn.Close();
            conn.Open();
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                return true;
            }
            return false;
        }
    }
}
