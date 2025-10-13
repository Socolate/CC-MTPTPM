using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DTO
{
    class CHUYENGANHDTO
    {
        public int MACN { get; set; }
        public string TenCN { get; set; }
        public int MAKHOA { get; set; }
        public CHUYENGANHDTO()
        {
            MACN = 0;
            TenCN = "";
            MAKHOA = 0;
        }
    }
}
