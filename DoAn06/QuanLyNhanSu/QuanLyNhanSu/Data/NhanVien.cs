using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyNhanSu.Data
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string MaPB { get; set; }
        public string MaHD { get; set; }
        public int HeSoLuong { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public DateOnly NgaySinh { get; set; }
        public string SoCM { get; set; }
        public string DienThoai { get; set; }
        public string TrinhDoHV { get; set; }
        public string DiaChi { get; set; }
        public string? Email { get; set; }
        public string Hinh { get; set; }
        public string TTHonNhan { get; set; }

        public virtual PhongBan PhongBan { get; set; }
        public virtual Luong Luong { get; set; }
        public virtual HopDong HopDong { get; set; }
        public virtual ObservableCollectionListSource<Taikhoan> Taikhoan { get; } = new();
        public virtual ObservableCollectionListSource<ThuongPhat> ThuongPhat { get; } = new();
        public virtual ObservableCollectionListSource<ChamCong> ChamCong { get; } = new();
        public virtual ObservableCollectionListSource<ctChucVu> ctChucVu { get; } = new();
        public virtual ObservableCollectionListSource<BaoHiem> BaoHiem { get; } = new();
        public virtual ObservableCollectionListSource<PhuCap> PhuCap { get; } = new();
    }
}