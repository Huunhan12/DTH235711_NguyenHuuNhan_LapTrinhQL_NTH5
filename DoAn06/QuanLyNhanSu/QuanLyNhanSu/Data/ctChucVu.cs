using System;

namespace QuanLyNhanSu.Data
{
    public class ctChucVu
    {
        public int Id { get; set; }
        public string? MaNhanVien { get; set; }
        public string? MaCV { get; set; }
        public DateOnly? NgayBatDau { get; set; }
        public DateOnly? NgayKetThuc { get; set; }
        public string? LyDo { get; set; }

        public virtual NhanVien NhanVien { get; set; }
        public virtual ChucVu ChucVu { get; set; }
    }
}