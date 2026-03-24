using System;
using System.Collections.Generic;

namespace QuanLyNhanSu.Data
{
    public class Taikhoan
    {
        public string MaNhanVien { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string TenQuyenHan { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}