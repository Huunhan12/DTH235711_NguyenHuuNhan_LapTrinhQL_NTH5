using Microsoft.EntityFrameworkCore;

namespace QuanLyNhanSu.Data
{
    public class QLNhanSuDbContext : DbContext
    {
        public DbSet<PhongBan> PhongBan { get; set; }
        public DbSet<ChucVu> ChucVu { get; set; }
        public DbSet<Luong> Luong { get; set; }
        public DbSet<HopDong> HopDong { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<Taikhoan> Taikhoan { get; set; }
        public DbSet<ThuongPhat> ThuongPhat { get; set; }
        public DbSet<ChamCong> ChamCong { get; set; }
        public DbSet<ctChucVu> ctChucVu { get; set; }
        public DbSet<BaoHiem> BaoHiem { get; set; }
        public DbSet<PhuCap> PhuCap { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer
                (
                    @"Server=LAPTOP-KT6FR8DE\SQLEXPRESS;Database=QLNS_DA1;Integrated Security=True;TrustServerCertificate=True",
                    providerOptions => providerOptions.EnableRetryOnFailure()
                );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // PhongBan
            modelBuilder.Entity<PhongBan>(entity =>
            {
                entity.HasKey(e => e.MaPB);
                entity.Property(e => e.MaPB).HasMaxLength(5);
                entity.Property(e => e.TenPB).HasMaxLength(20).IsRequired();
            });

            // ChucVu
            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.MaCV);
                entity.Property(e => e.MaCV).HasMaxLength(5);
                entity.Property(e => e.TenCv).HasMaxLength(20).IsRequired();
            });

            // Luong
            modelBuilder.Entity<Luong>(entity =>
            {
                entity.HasKey(e => e.HeSoLuong);
                entity.Property(e => e.LuongCB).IsRequired();
            });

            // HopDong
            modelBuilder.Entity<HopDong>(entity =>
            {
                entity.HasKey(e => e.MaHD);
                entity.Property(e => e.MaHD).HasMaxLength(5);
                entity.HasOne(e => e.Luong)
                      .WithMany(l => l.HopDong)
                      .HasForeignKey(e => e.HeSoLuong)
                      .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(e => e.ChucVu)
                      .WithMany(c => c.HopDong)
                      .HasForeignKey(e => e.MaCV)
                      .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(e => e.PhongBan)
                      .WithMany(p => p.HopDong)
                      .HasForeignKey(e => e.MaPB)
                      .OnDelete(DeleteBehavior.NoAction);
            });

            // NhanVien
            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien);
                entity.Property(e => e.MaNhanVien).HasMaxLength(5);
                entity.Property(e => e.TenNV).HasMaxLength(100).IsRequired();
                entity.Property(e => e.GioiTinh).HasMaxLength(5).IsRequired();
                entity.Property(e => e.SoCM).HasMaxLength(20).IsRequired();
                entity.Property(e => e.DienThoai).HasMaxLength(20).IsRequired();
                entity.Property(e => e.TrinhDoHV).HasMaxLength(30).IsRequired();
                entity.Property(e => e.Email).HasMaxLength(20);
                entity.Property(e => e.Hinh).HasMaxLength(100).IsRequired();
                entity.Property(e => e.TTHonNhan).HasMaxLength(10).IsRequired();
                entity.HasOne(e => e.PhongBan)
                      .WithMany(p => p.NhanVien)
                      .HasForeignKey(e => e.MaPB)
                      .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(e => e.Luong)
                      .WithMany(l => l.NhanVien)
                      .HasForeignKey(e => e.HeSoLuong)
                      .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(e => e.HopDong)
                      .WithMany(h => h.NhanVien)
                      .HasForeignKey(e => e.MaHD)
                      .OnDelete(DeleteBehavior.NoAction);
            });

            // Taikhoan
            modelBuilder.Entity<Taikhoan>(entity =>
            {
                entity.HasKey(e => e.TenDangNhap);
                entity.Property(e => e.TenDangNhap).HasMaxLength(50);
                entity.Property(e => e.MatKhau).HasMaxLength(50).IsRequired();
                entity.Property(e => e.TenQuyenHan).HasMaxLength(20).IsRequired();
                entity.HasOne(e => e.NhanVien)
                      .WithMany(n => n.Taikhoan)
                      .HasForeignKey(e => e.MaNhanVien)
                      .OnDelete(DeleteBehavior.NoAction);
            });

            // ThuongPhat
            modelBuilder.Entity<ThuongPhat>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(e => e.NhanVien)
                      .WithMany(n => n.ThuongPhat)
                      .HasForeignKey(e => e.MaNhanVien)
                      .OnDelete(DeleteBehavior.NoAction);
            });

            // ChamCong
            modelBuilder.Entity<ChamCong>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(e => e.NhanVien)
                      .WithMany(n => n.ChamCong)
                      .HasForeignKey(e => e.MaNhanVien)
                      .OnDelete(DeleteBehavior.NoAction);
            });

            // ctChucVu
            modelBuilder.Entity<ctChucVu>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(e => e.NhanVien)
                      .WithMany(n => n.ctChucVu)
                      .HasForeignKey(e => e.MaNhanVien)
                      .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(e => e.ChucVu)
                      .WithMany(c => c.ctChucVu)
                      .HasForeignKey(e => e.MaCV)
                      .OnDelete(DeleteBehavior.NoAction);
            });

            // BaoHiem
            modelBuilder.Entity<BaoHiem>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(e => e.NhanVien)
                      .WithMany(n => n.BaoHiem)
                      .HasForeignKey(e => e.MaNhanVien)
                      .OnDelete(DeleteBehavior.NoAction);
            });

            // PhuCap
            modelBuilder.Entity<PhuCap>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(e => e.NhanVien)
                      .WithMany(n => n.PhuCap)
                      .HasForeignKey(e => e.MaNhanVien)
                      .OnDelete(DeleteBehavior.NoAction);
            });
        }
    }
}