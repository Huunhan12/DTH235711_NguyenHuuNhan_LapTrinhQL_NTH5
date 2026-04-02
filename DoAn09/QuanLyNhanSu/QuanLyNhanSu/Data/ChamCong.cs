using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyNhanSu.Data
{
    public class ChamCong
    {
        public int Id { get; set; }

        public string MaNhanVien { get; set; }
        public DateOnly Ngay { get; set; }
        public string? TinhTrang { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}