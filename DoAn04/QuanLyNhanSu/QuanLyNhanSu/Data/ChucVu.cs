using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking; // Cần thiết cho ObservableCollectionListSource

namespace QuanLyNhanSu.Data
{
    public class ChucVu
    {
        public string MaCV { get; set; }
        public string TenCv { get; set; }
        public virtual ObservableCollectionListSource<HopDong> HopDong { get; } = new();
        public virtual ObservableCollectionListSource<ctChucVu> ctChucVu { get; } = new();
    }
}