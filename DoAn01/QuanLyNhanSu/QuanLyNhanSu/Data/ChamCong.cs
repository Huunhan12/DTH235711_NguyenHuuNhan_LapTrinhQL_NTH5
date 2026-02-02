using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Data
{
    public class ChamCong
    {
        public int ID { get; set; }
        public string MaNhanVien { get; set; } = null!;
        public DateTime Ngay { get; set; }
        public string? TinhTrang { get; set; }
        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}
