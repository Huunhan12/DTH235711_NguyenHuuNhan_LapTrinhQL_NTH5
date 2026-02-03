using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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
            if (!optionsBuilder.IsConfigured)
            {
                string conn = ConfigurationManager
                    .ConnectionStrings["QLBHConnection"]
                    .ConnectionString;

                optionsBuilder.UseMySql(
                    conn,
                    new MySqlServerVersion(new Version(8, 0, 34))
                );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhongBan>().HasKey(e => e.MaPB);
            modelBuilder.Entity<ChucVu>().HasKey(e => e.MaCV);
            modelBuilder.Entity<Luong>().HasKey(e => e.HeSoLuong);
            modelBuilder.Entity<HopDong>().HasKey(e => e.MaHD);
            modelBuilder.Entity<NhanVien>().HasKey(e => e.MaNhanVien);
            modelBuilder.Entity<Taikhoan>().HasKey(e => e.TenDangNhap);

            // Tắt cascade delete (MySQL hay lỗi)
            foreach (var fk in modelBuilder.Model
                         .GetEntityTypes()
                         .SelectMany(e => e.GetForeignKeys()))
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}

