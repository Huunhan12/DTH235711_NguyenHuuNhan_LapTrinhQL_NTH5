using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Data
{
    public class QLNhanSuDbContext : DbContext
    {
        public DbSet<PhongBan> PhongBan { get; set; } = null!;
        public DbSet<ChucVu> ChucVu { get; set; } = null!;
        public DbSet<Luong> Luong { get; set; } = null!;
        public DbSet<HopDong> HopDong { get; set; } = null!;
        public DbSet<NhanVien> NhanVien { get; set; } = null!;
        public DbSet<Taikhoan> Taikhoan { get; set; } = null!;
        public DbSet<ThuongPhat> ThuongPhat { get; set; } = null!;
        public DbSet<ChamCong> ChamCong { get; set; } = null!;
        public DbSet<ctChucVu> ctChucVu { get; set; } = null!;
        public DbSet<BaoHiem> BaoHiem { get; set; } = null!;
        public DbSet<PhuCap> PhuCap { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=QlNhanSu_V1;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhongBan>().HasKey(e => e.MaPB);
            modelBuilder.Entity<ChucVu>().HasKey(e => e.MaCV);
            modelBuilder.Entity<Luong>().HasKey(e => e.HeSoLuong);
            modelBuilder.Entity<HopDong>().HasKey(e => e.MaHD);
            modelBuilder.Entity<NhanVien>().HasKey(e => e.MaNhanVien);
            modelBuilder.Entity<Taikhoan>().HasKey(e => e.TenDangNhap);
            // Tắt chế độ tự động xóa (Cascade Delete) trên bảng NhanVien
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.NoAction;
            }
        }
    }
}
