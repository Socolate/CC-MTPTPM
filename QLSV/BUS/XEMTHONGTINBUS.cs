using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV.DAO;

namespace QLSV.BUS
{
    class XEMTHONGTINBUS
    {   XEMTHONGTINDAO TTSV=new XEMTHONGTINDAO();
        public DataTable layDSTTSV() {
            DataTable dt = TTSV.getTTSV();
            foreach (DataRow row in dt.Rows)
            {
                int masv = Convert.ToInt32(row["Mã Sinh Viên"]);
                row["Mã Sinh Viên"] = "030623" + masv.ToString("");

            }
            return dt;
        }
        public DataTable searchCN(string TENCN)
        {
            DataTable dt = TTSV.getTTSV();
            string dk = string.Format("[Chuyên Ngành]='{0}'", TENCN);
            DataRow[] rows = dt.Select(dk);
            DataTable kq=dt.Clone();
            foreach (DataRow row in rows)
            {
                kq.ImportRow(row);
            }
            foreach (DataRow row in kq.Rows)
            {
                int masv = Convert.ToInt32(row["Mã Sinh Viên"]);
                row["Mã Sinh Viên"] = "030623" + masv.ToString("");

            }
            return kq;
        }
        public DataTable searchLOP(string TENLOP)
        {
            DataTable dt = TTSV.getTTSV();
            string dk = string.Format("[Lớp]='{0}'", TENLOP);
            DataRow[] rows = dt.Select(dk);
            DataTable kq = dt.Clone();

            foreach (DataRow row in rows)
            {
                
                kq.ImportRow(row);
            }
            foreach (DataRow row in kq.Rows)
            {
                int masv = Convert.ToInt32(row["Mã Sinh Viên"]);
                row["Mã Sinh Viên"] = "030623" + masv.ToString("");

            }
            return kq;
        }
        public DataTable searchMSSV(string MSSV)
        {
            DataTable dt=TTSV.getTTSV();
            string dk = string.Format("[Mã Sinh Viên]='{0}'", MSSV);
            DataRow[] rows= dt.Select(dk);
            DataTable kq = dt.Clone();
            foreach(DataRow row in rows)
            {

                kq.ImportRow(row);
            }
            foreach (DataRow row in kq.Rows)
            {
                int masv = Convert.ToInt32(row["Mã Sinh Viên"]);
                row["Mã Sinh Viên"] = "030623" + masv.ToString("");

            }
            return kq;
        }
        
    }
}
