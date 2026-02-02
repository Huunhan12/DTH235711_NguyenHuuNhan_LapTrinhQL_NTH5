using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Data
{
    public class PhuCap
    {
        public int ID { get; set; }
        public string MaNhanVien { get; set; } = null!;
        public string? LoaiPC { get; set; }
        public int? Tien { get; set; }
        public DateTime? TuNgay { get; set; }
        public DateTime? DenNgay { get; set; }
        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}

