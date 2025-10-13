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
    class MONHOCBUS
    {   MONHOCDAO MH=new MONHOCDAO();
        public DataTable getMonHoc()
        {
            return MH.getMonHoc();
        }
        public bool themMonHoc(MONHOCDTO monHoc)
        {
            return MH.themMH(monHoc);
        }
        public bool suaMonHoc(MONHOCDTO monHoc)
        {
            return MH.suaMH(monHoc);
        }
        public bool xoaMonHoc(MONHOCDTO monHoc)
        {
            return MH.xoaMH(monHoc);
        }
    }
}
