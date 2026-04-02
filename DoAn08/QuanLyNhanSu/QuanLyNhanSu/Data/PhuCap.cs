using System;
using System.Collections.Generic;

namespace QuanLyNhanSu.Data
{
    public class PhuCap
    {
        public int Id { get; set; }

        public string MaNhanVien { get; set; }
        public string? LoaiPC { get; set; }
        public int? Tien { get; set; }
        public DateOnly? TuNgay { get; set; }
        public DateOnly? DenNgay { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}