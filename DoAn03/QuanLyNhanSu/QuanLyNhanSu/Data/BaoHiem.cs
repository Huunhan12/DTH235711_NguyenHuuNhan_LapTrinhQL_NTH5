using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyNhanSu.Data
{
    public class BaoHiem
    {
   
        public string MaNhanVien { get; set; } = null!;

        public string? LoaiBaoHiem { get; set; }

        public string? SoThe { get; set; }

        public DateTime? NgayCap { get; set; }

        public DateTime? NgayHetHan { get; set; }

        public string? NoiCap { get; set; }

        // Liên kết ngược về bảng NhanVien (Navigation Property)
        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}