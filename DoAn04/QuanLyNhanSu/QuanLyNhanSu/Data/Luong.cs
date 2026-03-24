using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking; // Cần thiết để dùng ObservableCollectionListSource

namespace QuanLyNhanSu.Data
{
    public partial class Luong
    {
        public int HeSoLuong { get; set; }
        public int LuongCB { get; set; }
        public virtual ObservableCollectionListSource<HopDong> HopDong { get; } = new();
        public virtual ObservableCollectionListSource<NhanVien> NhanVien { get; } = new();
    }
}