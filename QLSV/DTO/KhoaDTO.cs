using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DTO
{
    class KhoaDTO
    {
        public int MAKHOA { get; set; }
        public string TenKhoa { get; set; }

        public string GmailKhoa { get; set; }

        public KhoaDTO() { 
            MAKHOA = 0;
            TenKhoa = "";
            GmailKhoa = "";
        }
    }
}
