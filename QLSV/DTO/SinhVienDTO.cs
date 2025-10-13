using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DTO
{
    class SinhVienDTO
    {
        public int mssv { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string gmail { get; set; }
        public string SDT { get; set; }
        public int malop { get; set; }

        public SinhVienDTO() {
            this.mssv =0;
            this.HoTen =string.Empty;
            this.NgaySinh=DateTime.Now;
            this.GioiTinh=true;
            this.DiaChi=string.Empty;
            this.gmail =string.Empty;
            this.SDT =string.Empty;
            this.malop = 0;

        }
    }
}
