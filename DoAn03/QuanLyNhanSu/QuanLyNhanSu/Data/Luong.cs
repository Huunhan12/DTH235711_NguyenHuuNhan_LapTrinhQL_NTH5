using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking; // Cần thiết để dùng ObservableCollectionListSource

namespace QuanLyNhanSu.Data
{
    public partial class Luong
    {
        // SQL: HeSoLuong int Primary Key not null
        public int HeSoLuong { get; set; }

        // SQL: LuongCB int not null
        public int LuongCB { get; set; }

        // Navigation Properties: Một mức lương có thể áp dụng cho nhiều Hợp đồng và Nhân viên
        // Sử dụng ObservableCollectionListSource để hỗ trợ Data Binding tốt nhất trên WinForms
        public virtual ObservableCollectionListSource<HopDong> HopDongs { get; } = new();
        public virtual ObservableCollectionListSource<NhanVien> NhanViens { get; } = new();
    }
}