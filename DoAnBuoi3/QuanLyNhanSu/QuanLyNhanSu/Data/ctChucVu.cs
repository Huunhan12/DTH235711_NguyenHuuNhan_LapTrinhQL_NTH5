using System;

namespace QuanLyNhanSu.Data
{
    public class ctChucVu
    {
        // Xóa public int ID { get; set; } vì SQL không có cột này

        // SQL: MaNhanVien varchar(5) null
        public string? MaNhanVien { get; set; }

        // SQL: MaCV varchar(5) null
        public string? MaCV { get; set; }

        // SQL: NgayBatDau date null
        public DateTime? NgayBatDau { get; set; }

        // SQL: NgayKetThuc date null
        public DateTime? NgayKetThuc { get; set; }

        // SQL: LyDo nvarchar(100)
        public string? LyDo { get; set; }

        // Navigation Properties (Liên kết đến các bảng liên quan)
        public virtual NhanVien? NhanVien { get; set; }
        public virtual ChucVu? ChucVu { get; set; }
    }
}