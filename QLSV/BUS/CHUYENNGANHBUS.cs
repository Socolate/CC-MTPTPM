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
    class CHUYENNGANHBUS
    {   CHUYENNGANHDAO CN=new CHUYENNGANHDAO();
        public DataTable getChuyenNganh()
        {
            return CN.getChuyenNganh();
        }
        public bool themCN(CHUYENGANHDTO chuyenNganh)
        {
            return CN.themCH(chuyenNganh);
        }
        public bool xoaCN(CHUYENGANHDTO chuyenNganh)
        {
            return CN.xoaCH(chuyenNganh);
        }
        public bool suaCN(CHUYENGANHDTO suaNganh)
        {
            return CN.suaCH(suaNganh);
        }
        
    }
}
