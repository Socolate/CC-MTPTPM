using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DTO
{
    class NhapDiemDTO
    {
        public string MASV {  get; set; }
        public int MAMH { get; set; }
        public float DIEMCC { get; set; }
        public float DIEMTBK { get; set; }  
        public float DIEMTHI { get; set; }
        public float DIEMTONG { get; set; }
        public NhapDiemDTO() {
            MASV = "";
            MAMH = 0;
            DIEMCC = 0;
            DIEMTBK = 0;
            DIEMTHI = 0;
            DIEMTONG = 0;
        }
    }
}
