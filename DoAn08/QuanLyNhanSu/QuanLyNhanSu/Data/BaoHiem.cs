using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyNhanSu.Data
{
    public class BaoHiem
    {
        public int Id { get; set; }
        public string MaNhanVien { get; set; }
        public string? LoaiBaoHiem { get; set; }
        public string? SoThe { get; set; }
        public DateOnly? NgayCap { get; set; }
        public DateOnly? NgayHetHan { get; set; }
        public string? NoiCap { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}