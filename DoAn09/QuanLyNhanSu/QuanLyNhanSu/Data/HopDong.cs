using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking; // Thêm thư viện này

namespace QuanLyNhanSu.Data
{
    public class HopDong
    {
        public string MaHD { get; set; }
        public DateOnly NgayVaoLam { get; set; }
        public int HeSoLuong { get; set; }
        public string MaCV { get; set; }
        public string MaPB { get; set; }

        public virtual Luong Luong { get; set; }
        public virtual ChucVu ChucVu { get; set; }
        public virtual PhongBan PhongBan { get; set; }
        public virtual ObservableCollectionListSource<NhanVien> NhanVien { get; } = new();
    }
}