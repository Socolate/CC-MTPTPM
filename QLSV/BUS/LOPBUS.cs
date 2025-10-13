using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV.DAO;

namespace QLSV.BUS
{  
    class LOPBUS
    {
        LOPDAO LOP=new LOPDAO();
        public DataTable laydsslop()
        {
            return LOP.getlop();
        }
    }
}
