using System;

namespace QuanLyNhanSu.Data
{
    public class ThuongPhat
    {
        public string MaNhanVien { get; set; } = null!; // varchar(5) not null
        public string? Loai { get; set; }               // nvarchar(50) null
        public int? Tien { get; set; }                  // int null
        public string? LyDo { get; set; }               // nvarchar(max) null
        public DateTime? Ngay { get; set; }             // date

        // Navigation Property
        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}