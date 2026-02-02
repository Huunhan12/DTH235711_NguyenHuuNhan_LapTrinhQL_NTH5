using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Data
{
    public class Taikhoan
    {
        public string MaNhanVien { get; set; } = null!;
        public string TenDangNhap { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public string TenQuyenHan { get; set; } = null!;

        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}
