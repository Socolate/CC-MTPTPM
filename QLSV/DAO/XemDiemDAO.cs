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
    internal class XemDiemDAO:DataProvide
    {
        public DataTable getDiemTheoLop()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("getSinhVienTheoLop", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt; 
        }
        //public DataTable getSinhVienDau(string tenLop,int maMonHoc)
        //{
        //    DataTable dt = new DataTable();
        //    string str = String.Format("select\tc.MaLop,TenLop,HoTen,b.*, case when DiemTong>5 then 'dau' else 'rot' end as 'Ket Qua'\r\n\tfrom SinhVien a,BangDiem b,LopHoc c \r\n\twhere a.MaSinhVien=b.MaSinhVien and a.MaLop=c.MaLop and DiemTong>=5.0 and TenLop=N'{0}' and MaMonHoc='{1}'", tenLop, maMonHoc);
        //    SqlCommand cmd = new SqlCommand(str, conn);
        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    adapter.Fill(dt);
        //    return dt;
        //}
        //public DataTable getSinhVienRot(string tenLop, int maMonHoc)
        //{
        //    DataTable dt = new DataTable();
        //    string str = String.Format("select\tc.MaLop,TenLop,HoTen,b.*, case when DiemTong>5 then 'dau' else 'rot' end as 'Ket Qua'\r\n\tfrom SinhVien a,BangDiem b,LopHoc c \r\n\twhere a.MaSinhVien=b.MaSinhVien and a.MaLop=c.MaLop and DiemTong<5.0 and TenLop=N'{0}' and MaMonHoc='{1}'", tenLop, maMonHoc);
        //    SqlCommand cmd = new SqlCommand(str, conn);
        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    adapter.Fill(dt);
        //    return dt;
        //}
    }
}
