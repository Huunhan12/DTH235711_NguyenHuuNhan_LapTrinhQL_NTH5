using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Data
{
    public class Luong
    {
        public int HeSoLuong { get; set; }
        public int LuongCB { get; set; }

        public virtual ICollection<HopDong> HopDong { get; set; } = new List<HopDong>();
        public virtual ICollection<NhanVien> NhanVien { get; set; } = new List<NhanVien>();
    }
}

