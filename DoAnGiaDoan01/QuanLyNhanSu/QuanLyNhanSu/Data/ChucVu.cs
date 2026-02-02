using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Data
{
    public class ChucVu
    {
        public string MaCV { get; set; } = null!;
        public string TenCv { get; set; } = null!;

        public virtual ICollection<HopDong> HopDong { get; set; } = new List<HopDong>();
        public virtual ICollection<ctChucVu> ctChucVu { get; set; } = new List<ctChucVu>();
    }
}
