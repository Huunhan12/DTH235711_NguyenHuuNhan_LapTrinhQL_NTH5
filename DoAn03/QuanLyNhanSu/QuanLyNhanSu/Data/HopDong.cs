using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking; // Thêm thư viện này

namespace QuanLyNhanSu.Data
{
    public class HopDong
    {
        // SQL: MaHD varchar(5) not null Primary Key
        public string MaHD { get; set; } = null!;

        // SQL: NgayVaoLam date not null
        public DateTime NgayVaoLam { get; set; }

        // SQL: HeSoLuong int not null (Foreign Key)
        public int HeSoLuong { get; set; }

        // SQL: MaCV varchar(5) not null (Foreign Key)
        public string MaCV { get; set; } = null!;

        // SQL: MaPB varchar(5) not null (Foreign Key)
        public string MaPB { get; set; } = null!;

        // Navigation Properties - Các liên kết 1-n (đến bảng cha)
        public virtual Luong Luong { get; set; } = null!;
        public virtual ChucVu ChucVu { get; set; } = null!;
        public virtual PhongBan PhongBan { get; set; } = null!;

        // Navigation Property - Liên kết n-1 (đến bảng con NhanVien)
        // Dùng ObservableCollectionListSource để DataGridView tự cập nhật mượt mà
        public virtual ObservableCollectionListSource<NhanVien> NhanViens { get; } = new();
    }
}