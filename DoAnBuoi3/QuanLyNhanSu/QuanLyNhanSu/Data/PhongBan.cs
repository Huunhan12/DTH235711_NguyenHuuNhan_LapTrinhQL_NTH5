using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking; // Cần thiết để dùng ObservableCollectionListSource

namespace QuanLyNhanSu.Data
{
    public class PhongBan
    {
        // SQL: MaPB varchar(5) not null Primary Key
        public string MaPB { get; set; } = null!;

        // SQL: TenPB nvarchar(20) not null
        public string TenPB { get; set; } = null!;

        // Quan hệ: Một phòng ban có nhiều nhân viên và hợp đồng
        // Sử dụng ObservableCollectionListSource để Guna2DataGridView tự động cập nhật UI
        public virtual ObservableCollectionListSource<NhanVien> NhanViens { get; } = new();
        public virtual ObservableCollectionListSource<HopDong> HopDongs { get; } = new();
    }
}