using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyNhanSu.Data
{
    public class ChamCong
    {
      
        public string MaNhanVien { get; set; } = null!; // MaNhanVien varchar(5) not null

        public DateTime Ngay { get; set; } // Ngay date not null

        public string? TinhTrang { get; set; } // TinhTrang Nvarchar(20) null

        // Navigation property: Liên kết đến bảng NhanVien
        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}