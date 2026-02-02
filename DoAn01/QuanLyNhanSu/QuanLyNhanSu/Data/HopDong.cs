using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Data
{
    public class HopDong
    {
        public string MaHD { get; set; } = null!;
        public DateTime NgayVaoLam { get; set; }
        public int HeSoLuong { get; set; }
        public string MaCV { get; set; } = null!;
        public string MaPB { get; set; } = null!;

        public virtual Luong Luong { get; set; } = null!;
        public virtual ChucVu ChucVu { get; set; } = null!;
        public virtual PhongBan PhongBan { get; set; } = null!;
        public virtual ICollection<NhanVien> NhanVien { get; set; } = new List<NhanVien>();
    }
}
