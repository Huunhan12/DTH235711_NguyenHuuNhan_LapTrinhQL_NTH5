using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Data
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; } = null!;
        public string MaPB { get; set; } = null!;
        public string MaHD { get; set; } = null!;
        public int HeSoLuong { get; set; }
        public string TenNV { get; set; } = null!;
        public string GioiTinh { get; set; } = null!;
        public DateTime NgaySinh { get; set; }
        public string SoCM { get; set; } = null!;
        public string DienThoai { get; set; } = null!;
        public string TrinhDoHV { get; set; } = null!;
        public string DiaChi { get; set; } = null!;
        public string? Email { get; set; }
        public string Hinh { get; set; } = null!;
        public string TTHonNhan { get; set; } = null!;

        public virtual PhongBan PhongBan { get; set; } = null!;
        public virtual Luong Luong { get; set; } = null!;
        public virtual HopDong HopDong { get; set; } = null!;

        public virtual ICollection<Taikhoan> Taikhoan { get; set; } = new List<Taikhoan>();
        public virtual ICollection<ThuongPhat> ThuongPhat { get; set; } = new List<ThuongPhat>();
        public virtual ICollection<ChamCong> ChamCong { get; set; } = new List<ChamCong>();
        public virtual ICollection<ctChucVu> ctChucVu { get; set; } = new List<ctChucVu>();
        public virtual ICollection<BaoHiem> BaoHiem { get; set; } = new List<BaoHiem>();
        public virtual ICollection<PhuCap> PhuCap { get; set; } = new List<PhuCap>();
    }
}
