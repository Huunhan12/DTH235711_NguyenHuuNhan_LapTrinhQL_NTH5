using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Data
{
    public class PhongBan
    {
        public string MaPB { get; set; } = null!;
        public string TenPB { get; set; } = null!;

        // Quan hệ: Một phòng ban có nhiều nhân viên và hợp đồng
        public virtual ICollection<NhanVien> NhanVien { get; set; } = new List<NhanVien>();
        public virtual ICollection<HopDong> HopDong { get; set; } = new List<HopDong>();
    }
}
