using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace QuanLyBanHang.Data
{
    [Table("HangSanXuat")]
    public class HangSanXuat
    {
        [Key]
        public int ID { get; set; }
        public string TenHangSanXuat { get; set; }
        public virtual ObservableCollectionListSource<SanPham> SanPham { get; } = new();
    }
}
