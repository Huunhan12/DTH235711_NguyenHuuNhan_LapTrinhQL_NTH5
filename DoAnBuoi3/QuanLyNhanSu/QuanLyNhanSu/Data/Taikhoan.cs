using System;
using System.Collections.Generic;

namespace QuanLyNhanSu.Data
{
    public class Taikhoan
    {
        // SQL: TenDangNhap nvarchar(50) primary key not null
        public string TenDangNhap { get; set; } = null!;

        // SQL: MaNhanVien varchar(5) not null (Foreign Key)
        public string MaNhanVien { get; set; } = null!;

        // SQL: MatKhau nvarchar(50) not null
        public string MatKhau { get; set; } = null!;

        // SQL: TenQuyenHan Nvarchar(20) not null
        public string TenQuyenHan { get; set; } = null!;

        // Navigation Property: Mỗi tài khoản thuộc về một nhân viên cụ thể
        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}