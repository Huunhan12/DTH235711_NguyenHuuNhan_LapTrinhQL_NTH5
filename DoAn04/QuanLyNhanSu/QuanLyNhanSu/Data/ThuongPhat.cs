using System;

namespace QuanLyNhanSu.Data
{
    public class ThuongPhat
    {
        public int Id { get; set; }
        public string MaNhanVien { get; set; }
        public string? Loai { get; set; }
        public int? Tien { get; set; }
        public string? LyDo { get; set; }
        public DateOnly? Ngay { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}