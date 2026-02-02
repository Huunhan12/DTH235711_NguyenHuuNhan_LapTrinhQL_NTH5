using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyNhanSu.Migrations
{
    /// <inheritdoc />
    public partial class QLNS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    MaCV = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenCv = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.MaCV);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Luong",
                columns: table => new
                {
                    HeSoLuong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LuongCB = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luong", x => x.HeSoLuong);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PhongBan",
                columns: table => new
                {
                    MaPB = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenPB = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBan", x => x.MaPB);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HopDong",
                columns: table => new
                {
                    MaHD = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NgayVaoLam = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HeSoLuong = table.Column<int>(type: "int", nullable: false),
                    MaCV = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MaPB = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LuongHeSoLuong = table.Column<int>(type: "int", nullable: false),
                    ChucVuMaCV = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhongBanMaPB = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HopDong", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_HopDong_ChucVu_ChucVuMaCV",
                        column: x => x.ChucVuMaCV,
                        principalTable: "ChucVu",
                        principalColumn: "MaCV",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HopDong_Luong_LuongHeSoLuong",
                        column: x => x.LuongHeSoLuong,
                        principalTable: "Luong",
                        principalColumn: "HeSoLuong",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HopDong_PhongBan_PhongBanMaPB",
                        column: x => x.PhongBanMaPB,
                        principalTable: "PhongBan",
                        principalColumn: "MaPB",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MaPB = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MaHD = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HeSoLuong = table.Column<int>(type: "int", nullable: false),
                    TenNV = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GioiTinh = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NgaySinh = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    SoCM = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DienThoai = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TrinhDoHV = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DiaChi = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hinh = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TTHonNhan = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhongBanMaPB = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LuongHeSoLuong = table.Column<int>(type: "int", nullable: false),
                    HopDongMaHD = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNhanVien);
                    table.ForeignKey(
                        name: "FK_NhanVien_HopDong_HopDongMaHD",
                        column: x => x.HopDongMaHD,
                        principalTable: "HopDong",
                        principalColumn: "MaHD",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhanVien_Luong_LuongHeSoLuong",
                        column: x => x.LuongHeSoLuong,
                        principalTable: "Luong",
                        principalColumn: "HeSoLuong",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhanVien_PhongBan_PhongBanMaPB",
                        column: x => x.PhongBanMaPB,
                        principalTable: "PhongBan",
                        principalColumn: "MaPB",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BaoHiem",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MaNhanVien = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ngay = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TinhTrang = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NhanVienMaNhanVien = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaoHiem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BaoHiem_NhanVien_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChamCong",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MaNhanVien = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ngay = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TinhTrang = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NhanVienMaNhanVien = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChamCong", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ChamCong_NhanVien_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ctChucVu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MaNhanVien = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MaCV = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NgayBatDau = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LyDo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NhanVienMaNhanVien = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ChucVuMaCV = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ctChucVu", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ctChucVu_ChucVu_ChucVuMaCV",
                        column: x => x.ChucVuMaCV,
                        principalTable: "ChucVu",
                        principalColumn: "MaCV",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ctChucVu_NhanVien_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PhuCap",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MaNhanVien = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoaiPC = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tien = table.Column<int>(type: "int", nullable: true),
                    TuNgay = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DenNgay = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    NhanVienMaNhanVien = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuCap", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PhuCap_NhanVien_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Taikhoan",
                columns: table => new
                {
                    TenDangNhap = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MaNhanVien = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MatKhau = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenQuyenHan = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NhanVienMaNhanVien = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taikhoan", x => x.TenDangNhap);
                    table.ForeignKey(
                        name: "FK_Taikhoan_NhanVien_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ThuongPhat",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MaNhanVien = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Loai = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tien = table.Column<int>(type: "int", nullable: true),
                    LyDo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ngay = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    NhanVienMaNhanVien = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuongPhat", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ThuongPhat_NhanVien_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_BaoHiem_NhanVienMaNhanVien",
                table: "BaoHiem",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_ChamCong_NhanVienMaNhanVien",
                table: "ChamCong",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_ctChucVu_ChucVuMaCV",
                table: "ctChucVu",
                column: "ChucVuMaCV");

            migrationBuilder.CreateIndex(
                name: "IX_ctChucVu_NhanVienMaNhanVien",
                table: "ctChucVu",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HopDong_ChucVuMaCV",
                table: "HopDong",
                column: "ChucVuMaCV");

            migrationBuilder.CreateIndex(
                name: "IX_HopDong_LuongHeSoLuong",
                table: "HopDong",
                column: "LuongHeSoLuong");

            migrationBuilder.CreateIndex(
                name: "IX_HopDong_PhongBanMaPB",
                table: "HopDong",
                column: "PhongBanMaPB");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_HopDongMaHD",
                table: "NhanVien",
                column: "HopDongMaHD");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_LuongHeSoLuong",
                table: "NhanVien",
                column: "LuongHeSoLuong");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_PhongBanMaPB",
                table: "NhanVien",
                column: "PhongBanMaPB");

            migrationBuilder.CreateIndex(
                name: "IX_PhuCap_NhanVienMaNhanVien",
                table: "PhuCap",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_Taikhoan_NhanVienMaNhanVien",
                table: "Taikhoan",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_ThuongPhat_NhanVienMaNhanVien",
                table: "ThuongPhat",
                column: "NhanVienMaNhanVien");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaoHiem");

            migrationBuilder.DropTable(
                name: "ChamCong");

            migrationBuilder.DropTable(
                name: "ctChucVu");

            migrationBuilder.DropTable(
                name: "PhuCap");

            migrationBuilder.DropTable(
                name: "Taikhoan");

            migrationBuilder.DropTable(
                name: "ThuongPhat");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "HopDong");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "Luong");

            migrationBuilder.DropTable(
                name: "PhongBan");
        }
    }
}
