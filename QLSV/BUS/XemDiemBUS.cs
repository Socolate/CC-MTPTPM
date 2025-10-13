using QLSV.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.BUS
{
    internal class XemDiemBUS
    {
        XemDiemDAO xd=new XemDiemDAO();
        NHAPDIEMDAO nd=new NHAPDIEMDAO();
        public DataTable getDiem()
        {
            DataTable dt = xd.getDiemTheoLop();
            foreach (DataRow row in dt.Rows)
            {
                int masv = Convert.ToInt32(row["Mã Sinh Viên"]);
                row["Mã Sinh Viên"] = "030623" + masv.ToString("");

            }
            return dt;
        }
        public DataTable xemDiemTheoLop(string tenlop, int mamh)
        {
            DataTable dt = xd.getDiemTheoLop();
            string dk = string.Format("[Tên lớp]='{0}' and [Mã môn học]='{1}'", tenlop, mamh);
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
        public DataTable xemDiemTheoSV_ChuaNhapMaMonHoc(string masv)
        {
            DataTable dt = nd.getDiem();
            string dk = string.Format("[Mã Sinh Viên]='{0}'", masv);
            DataRow[] rows = dt.Select(dk);
            DataTable kq = dt.Clone();
            foreach (DataRow row in rows)
            {
                kq.ImportRow(row);
            }
            foreach (DataRow row in kq.Rows)
            {
                int a = Convert.ToInt32(row["Mã Sinh Viên"]);
                row["Mã Sinh Viên"] = "030623" + a.ToString("");

            }
            return kq;
        }
        public DataTable xemDiemTheoSV(string masv, int mamh)
        {
            DataTable dt = nd.getDiem();
            string dk = string.Format("[Mã Sinh Viên]='{0}' and [Mã môn học]='{1}'", masv, mamh);
            DataRow[] rows = dt.Select(dk);
            DataTable kq = dt.Clone();
            foreach (DataRow row in rows)
            {
                kq.ImportRow(row);
            }
            foreach (DataRow row in kq.Rows)
            {
                int a = Convert.ToInt32(row["Mã Sinh Viên"]);
                row["Mã Sinh Viên"] = "030623" + a.ToString("");

            }
            return kq;
        }
        public DataTable getSinhVienDau(string tenlop, int mamh)
        {
            DataTable dt = xd.getDiemTheoLop();
            string dk = string.Format("[Tên lớp]='{0}' and [Mã môn học]='{1}' and [Điểm tổng]>=5.0", tenlop, mamh);
            DataRow[] rows = dt.Select(dk);
            DataTable kq = dt.Clone();
            foreach (DataRow row in rows)
            {
                kq.ImportRow(row);
            }
            foreach (DataRow row in kq.Rows)
            {
                int a = Convert.ToInt32(row["Mã Sinh Viên"]);
                row["Mã Sinh Viên"] = "030623" + a.ToString("");

            }

            return kq;
        }
        public DataTable getSinhVienDau_KhiChuaNhapMaMonHoc(string tenlop)
        {
            DataTable dt = xd.getDiemTheoLop();
            string dk = string.Format("[Tên lớp]='{0}' and [Điểm tổng]>=5.0", tenlop);
            DataRow[] rows = dt.Select(dk);
            DataTable kq = dt.Clone();
            foreach (DataRow row in rows)
            {
                kq.ImportRow(row);
            }
            foreach (DataRow row in kq.Rows)
            {
                int a = Convert.ToInt32(row["Mã Sinh Viên"]);
                row["Mã Sinh Viên"] = "030623" + a.ToString("");

            }

            return kq;
        }
        public DataTable getSinhVienRot(string tenlop, int mamh)
        {
            DataTable dt = xd.getDiemTheoLop();
            string dk = string.Format("[Tên lớp]='{0}' and [Mã môn học]='{1}' and [Điểm tổng]<5.0", tenlop, mamh);
            DataRow[] rows = dt.Select(dk);
            DataTable kq = dt.Clone();
            foreach (DataRow row in rows)
            {
                kq.ImportRow(row);
            }
            foreach (DataRow row in kq.Rows)
            {
                int a = Convert.ToInt32(row["Mã Sinh Viên"]);
                row["Mã Sinh Viên"] = "030623" + a.ToString("");

            }
            return kq;
        }
        public DataTable getSinhVienRot_KhiChuaNhapMaMonHoc(string tenlop)
        {
            DataTable dt = xd.getDiemTheoLop();
            string dk = string.Format("[Tên lớp]='{0}' and [Điểm tổng]<5.0", tenlop);
            DataRow[] rows = dt.Select(dk);
            DataTable kq = dt.Clone();
            foreach (DataRow row in rows)
            {
                kq.ImportRow(row);
            }
            foreach (DataRow row in kq.Rows)
            {
                int a = Convert.ToInt32(row["Mã Sinh Viên"]);
                row["Mã Sinh Viên"] = "030623" + a.ToString("");

            }
            return kq;
        }
    }
}
