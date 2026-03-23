using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking; // Cần thiết cho ObservableCollectionListSource

namespace QuanLyNhanSu.Data
{
    public class ChucVu
    {
        // SQL: MaCV varchar(5) not null Primary Key
        public string MaCV { get; set; } = null!;

        // SQL: TenCv nvarchar(20) not null
        public string TenCv { get; set; } = null!;

        // Sử dụng ObservableCollectionListSource giúp DataGridView tự động cập nhật khi dữ liệu thay đổi
        public virtual ObservableCollectionListSource<HopDong> HopDong { get; } = new();
       // public virtual ObservableCollectionListSource<ctChucVu> ctChucVu { get; } = new();
    }
}