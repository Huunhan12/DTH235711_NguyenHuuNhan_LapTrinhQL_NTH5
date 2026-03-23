using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyNhanSu.Data
{
    public class NhanVien
    {
        // Khóa chính (MaNhanVien varchar(5))
        public string MaNhanVien { get; set; } = null!;
        public string MaPB { get; set; } = null!;
        public string MaHD { get; set; } = null!;
        public int HeSoLuong { get; set; }

        public string TenNV { get; set; } = null!;
        public string GioiTinh { get; set; } = null!;
        public DateTime NgaySinh { get; set; }
        public string SoCM { get; set; } = null!;
        public string DienThoai { get; set; } = null!;
        public string TrinhDoHV { get; set; } = null!;
        public string DiaChi { get; set; } = null!;
        public string? Email { get; set; }
        public string Hinh { get; set; } = null!;
        public string TTHonNhan { get; set; } = null!;

        // Navigation Properties: Tham chiếu đến các bảng cha (1-1 hoặc n-1)
        public virtual PhongBan PhongBan { get; set; } = null!;
        public virtual Luong Luong { get; set; } = null!;
        public virtual HopDong HopDong { get; set; } = null!;

        // Navigation Properties: Tham chiếu đến các bảng con (1-n)
        // Sử dụng ObservableCollectionListSource để UI (Guna2DataGridView) tự động cập nhật
        public virtual ObservableCollectionListSource<Taikhoan> Taikhoans { get; } = new();
        //public virtual ObservableCollectionListSource<ThuongPhat> ThuongPhats { get; } = new();
        ///public virtual ObservableCollectionListSource<ChamCong> ChamCongs { get; } = new();
       // public virtual ObservableCollectionListSource<ctChucVu> ctChucVus { get; } = new();
        //public virtual ObservableCollectionListSource<BaoHiem> BaoHiems { get; } = new();
        //public virtual ObservableCollectionListSource<PhuCap> PhuCaps { get; } = new();
    }
}