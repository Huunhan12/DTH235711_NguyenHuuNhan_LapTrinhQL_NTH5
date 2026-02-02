using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Data
{
    public class ctChucVu
    {
        public int ID { get; set; }
        public string? MaNhanVien { get; set; }
        public string? MaCV { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string? LyDo { get; set; }
        public virtual NhanVien? NhanVien { get; set; }
        public virtual ChucVu? ChucVu { get; set; }
    }
}
