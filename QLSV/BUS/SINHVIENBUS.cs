using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV.DAO;
using QLSV.DTO;

namespace QLSV.BUS
{
    internal class SINHVIENBUS
    {
        SINHVIENDAO sv = new SINHVIENDAO();
        public DataTable layDSSSV()
        {
            DataTable dt= sv.GetData();
            foreach(DataRow row in dt.Rows) {
                int masv = Convert.ToInt32(row["Mã Sinh Viên"]);
                row["Mã Sinh Viên"] = "030623" + masv.ToString("");

            }
            return dt;
        }
        public bool ThemSV(SinhVienDTO sinhvien)
        {
            return sv.themSinhVien(sinhvien);

        }
        public bool SuaSV(SinhVienDTO sinhVien)
        {
            return sv.suaSinhVien(sinhVien);
        }
        public bool XoaSV(SinhVienDTO sinhvien)
        {
            return sv.xoaSinhVien(sinhvien);
        }
    }
}
