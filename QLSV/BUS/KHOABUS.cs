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
    class KHOABUS
    {
        KHOADAO KHOA = new KHOADAO();

        public DataTable getKhoaAll()
        {
            return KHOA.getKhoaGet();
        }
        public bool themKhoa(KhoaDTO khoa)
        {
            return KHOA.themKhoa(khoa);
        }
        public bool suaKhoa(KhoaDTO khoa)
        {
            return KHOA.suaKhoa(khoa);
        }
        public bool xoaKhoa(KhoaDTO khoa)
        {
            return KHOA.xoaKhoa(khoa);
        }
    }
}
