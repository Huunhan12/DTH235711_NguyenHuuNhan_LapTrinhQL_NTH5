using System;
using System.Collections.Generic;

namespace QuanLyNhanSu.Data
{
    public class PhuCap
    {

        // SQL: MaNhanVien Varchar(5) not null
        public string MaNhanVien { get; set; } = null!;

        // SQL: LoaiPC nvarchar(50) null
        public string? LoaiPC { get; set; }

        // SQL: Tien int null
        public int? Tien { get; set; }

        // SQL: TuNgay date null
        public DateTime? TuNgay { get; set; }

        // SQL: DenNgay date null
        public DateTime? DenNgay { get; set; }

        // Navigation Property: Liên kết đến bảng nhân viên
        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}