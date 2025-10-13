using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DTO
{
    class LOPDTO
    {
        public int MaLop {  get; set; }
        public string tenLop {  get; set; }

        public int maChuyenNganh { get; set; }
       
        public LOPDTO() { 
            MaLop = 0;
            tenLop = "";
            maChuyenNganh = 0;
        }
    }
}
