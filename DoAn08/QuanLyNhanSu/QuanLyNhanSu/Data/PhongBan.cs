using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking; // Cần thiết để dùng ObservableCollectionListSource

namespace QuanLyNhanSu.Data
{
    public class PhongBan
    {
        public string MaPB { get; set; }
        public string TenPB { get; set; }
        public virtual ObservableCollectionListSource<NhanVien> NhanVien { get; } = new();
        public virtual ObservableCollectionListSource<HopDong> HopDong { get; } = new();
    }
}