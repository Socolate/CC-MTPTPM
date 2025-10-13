using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DTO
{
    class MONHOCDTO
    {
        public int MaMH {  get; set; }

        public int TinChi { get; set; }

        public int HocKy { get; set; }
        public string TenMH { get; set; }

        public int ChuyenNganh {  get; set; }
        public MONHOCDTO() { 
            MaMH = 0;
            TinChi = 0;
            HocKy = 0;
            ChuyenNganh = 0;
            TenMH = "";
        }
        

    }
}
