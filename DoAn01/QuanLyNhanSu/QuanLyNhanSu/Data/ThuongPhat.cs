using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Data
{
    public class ThuongPhat
    {
        public int ID { get; set; } // PK giả định để EF Core quản lý
        public string MaNhanVien { get; set; } = null!;
        public string? Loai { get; set; }
        public int? Tien { get; set; }
        public string? LyDo { get; set; }
        public DateTime? Ngay { get; set; }
        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}
