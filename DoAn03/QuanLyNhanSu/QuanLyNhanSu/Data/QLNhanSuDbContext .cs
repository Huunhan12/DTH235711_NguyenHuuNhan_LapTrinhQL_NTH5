using Microsoft.EntityFrameworkCore;

namespace QuanLyNhanSu.Data
{
    public class QLNhanSuDbContext : DbContext
    {
        public QLNhanSuDbContext() { }

        public QLNhanSuDbContext(DbContextOptions<QLNhanSuDbContext> options) : base(options) { }

        public DbSet<PhongBan> PhongBans { get; set; } = null!;
        public DbSet<ChucVu> ChucVus { get; set; } = null!;
        public DbSet<Luong> Luongs { get; set; } = null!;
        public DbSet<HopDong> HopDongs { get; set; } = null!;
        public DbSet<NhanVien> NhanViens { get; set; } = null!;
        public DbSet<Taikhoan> Taikhoans { get; set; } = null!;
        public DbSet<ThuongPhat> ThuongPhats { get; set; } = null!;
        public DbSet<ChamCong> ChamCongs { get; set; } = null!;
        public DbSet<ctChucVu> ctChucVus { get; set; } = null!;
        public DbSet<BaoHiem> BaoHiems { get; set; } = null!;
        public DbSet<PhuCap> PhuCaps { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer
                (
                    @"Server=LAPTOP-KT6FR8DE\SQLEXPRESS;Database=QLNS_DA;Integrated Security=True;TrustServerCertificate=True",
                    providerOptions => providerOptions.EnableRetryOnFailure()
                );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 1. Cấu hình Khóa chính (Primary Key)
            modelBuilder.Entity<PhongBan>().HasKey(e => e.MaPB);
            modelBuilder.Entity<ChucVu>().HasKey(e => e.MaCV);
            modelBuilder.Entity<Luong>().HasKey(e => e.HeSoLuong);
            modelBuilder.Entity<HopDong>().HasKey(e => e.MaHD);
            modelBuilder.Entity<NhanVien>().HasKey(e => e.MaNhanVien);
            modelBuilder.Entity<Taikhoan>().HasKey(e => e.TenDangNhap);

            // 2. Cấu hình các bảng KHÔNG CÓ KHÓA CHÍNH (Keyless)
            modelBuilder.Entity<ChamCong>().HasNoKey();
            modelBuilder.Entity<ThuongPhat>().HasNoKey();
            modelBuilder.Entity<ctChucVu>().HasNoKey();
            modelBuilder.Entity<BaoHiem>().HasNoKey();
            modelBuilder.Entity<PhuCap>().HasNoKey();

            // 3. ĐỊNH NGHĨA QUAN HỆ CHO CÁC BẢNG KEYLESS (Quan trọng nhất để sửa lỗi Migration)

            // Cấu hình cho ctChucVu
            /* modelBuilder.Entity<ctChucVu>()
                 .HasOne(ct => ct.ChucVu)
                 .WithMany(cv => cv.ctChucVu)
                 .HasForeignKey(ct => ct.MaCV);

             modelBuilder.Entity<ctChucVu>()
                 .HasOne(ct => ct.NhanVien)
                 .WithMany(nv => nv.ctChucVus)
                 .HasForeignKey(ct => ct.MaNhanVien);

             // Cấu hình cho các bảng khác tương tự nếu bạn có ICollection trong NhanVien
             modelBuilder.Entity<ChamCong>()
                 .HasOne(cc => cc.NhanVien)
                 .WithMany(nv => nv.ChamCongs)
                 .HasForeignKey(cc => cc.MaNhanVien);

             modelBuilder.Entity<BaoHiem>()
                 .HasOne(bh => bh.NhanVien)
                 .WithMany(nv => nv.BaoHiems)
                 .HasForeignKey(bh => bh.MaNhanVien);

             modelBuilder.Entity<PhuCap>()
                 .HasOne(pc => pc.NhanVien)
                 .WithMany(nv => nv.PhuCaps)
                 .HasForeignKey(pc => pc.MaNhanVien);

             modelBuilder.Entity<ThuongPhat>()
                 .HasOne(tp => tp.NhanVien)
                 .WithMany(nv => nv.ThuongPhats)
                 .HasForeignKey(tp => tp.MaNhanVien);*/

            // 4. Tắt cascade delete
            foreach (var fk in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}