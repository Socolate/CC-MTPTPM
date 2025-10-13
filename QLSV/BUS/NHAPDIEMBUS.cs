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
    class NHAPDIEMBUS
    {   NHAPDIEMDAO ND=new NHAPDIEMDAO();
        public DataTable getDiem()
        {
            DataTable kq = ND.getDiem();
            foreach (DataRow row in kq.Rows)
            {
                int a = Convert.ToInt32(row["Mã Sinh Viên"]);
                row["Mã Sinh Viên"] = "030623" + a.ToString("");

            }
            return kq;
        }
          public DataTable getNhapDiem() {
            DataTable dt = ND.getDiem();
            foreach (DataRow row in dt.Rows)
            {
                int masv = Convert.ToInt32(row["Mã Sinh Viên"]);
                row["Mã Sinh Viên"] = "030623" + masv.ToString("");

            }
            return dt; }
        public bool NHAPDIEM(NhapDiemDTO NDiem)
        {
            return ND.nhapDiem(NDiem);
        }
        public bool suaDiem(NhapDiemDTO NDiem)
        {
            return ND.suaDiem(NDiem);
        }

    }

   
}
