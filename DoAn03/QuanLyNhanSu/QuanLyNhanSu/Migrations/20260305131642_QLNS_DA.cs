using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyNhanSu.Migrations
{
    /// <inheritdoc />
    public partial class QLNS_DA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVus",
                columns: table => new
                {
                    MaCV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenCv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVus", x => x.MaCV);
                });

            migrationBuilder.CreateTable(
                name: "Luongs",
                columns: table => new
                {
                    HeSoLuong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuongCB = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luongs", x => x.HeSoLuong);
                });

            migrationBuilder.CreateTable(
                name: "PhongBans",
                columns: table => new
                {
                    MaPB = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenPB = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBans", x => x.MaPB);
                });

            migrationBuilder.CreateTable(
                name: "HopDongs",
                columns: table => new
                {
                    MaHD = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayVaoLam = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HeSoLuong = table.Column<int>(type: "int", nullable: false),
                    MaCV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaPB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LuongHeSoLuong = table.Column<int>(type: "int", nullable: false),
                    ChucVuMaCV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhongBanMaPB = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HopDongs", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_HopDongs_ChucVus_ChucVuMaCV",
                        column: x => x.ChucVuMaCV,
                        principalTable: "ChucVus",
                        principalColumn: "MaCV",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HopDongs_Luongs_LuongHeSoLuong",
                        column: x => x.LuongHeSoLuong,
                        principalTable: "Luongs",
                        principalColumn: "HeSoLuong",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HopDongs_PhongBans_PhongBanMaPB",
                        column: x => x.PhongBanMaPB,
                        principalTable: "PhongBans",
                        principalColumn: "MaPB",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaPB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaHD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeSoLuong = table.Column<int>(type: "int", nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoCM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrinhDoHV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TTHonNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhongBanMaPB = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LuongHeSoLuong = table.Column<int>(type: "int", nullable: false),
                    HopDongMaHD = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.MaNhanVien);
                    table.ForeignKey(
                        name: "FK_NhanViens_HopDongs_HopDongMaHD",
                        column: x => x.HopDongMaHD,
                        principalTable: "HopDongs",
                        principalColumn: "MaHD",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhanViens_Luongs_LuongHeSoLuong",
                        column: x => x.LuongHeSoLuong,
                        principalTable: "Luongs",
                        principalColumn: "HeSoLuong",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhanViens_PhongBans_PhongBanMaPB",
                        column: x => x.PhongBanMaPB,
                        principalTable: "PhongBans",
                        principalColumn: "MaPB",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BaoHiems",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiBaoHiem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoThe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayCap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayHetHan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NoiCap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhanVienMaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_BaoHiems_NhanViens_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChamCongs",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhanVienMaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ChamCongs_NhanViens_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ctChucVus",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaCV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LyDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhanVienMaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ChucVuMaCV = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ctChucVus_ChucVus_ChucVuMaCV",
                        column: x => x.ChucVuMaCV,
                        principalTable: "ChucVus",
                        principalColumn: "MaCV",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ctChucVus_NhanViens_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhuCaps",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiPC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tien = table.Column<int>(type: "int", nullable: true),
                    TuNgay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DenNgay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NhanVienMaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_PhuCaps_NhanViens_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Taikhoans",
                columns: table => new
                {
                    TenDangNhap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenQuyenHan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NhanVienMaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taikhoans", x => x.TenDangNhap);
                    table.ForeignKey(
                        name: "FK_Taikhoans_NhanViens_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ThuongPhats",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Loai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tien = table.Column<int>(type: "int", nullable: true),
                    LyDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NhanVienMaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ThuongPhats_NhanViens_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaoHiems_NhanVienMaNhanVien",
                table: "BaoHiems",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_ChamCongs_NhanVienMaNhanVien",
                table: "ChamCongs",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_ctChucVus_ChucVuMaCV",
                table: "ctChucVus",
                column: "ChucVuMaCV");

            migrationBuilder.CreateIndex(
                name: "IX_ctChucVus_NhanVienMaNhanVien",
                table: "ctChucVus",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HopDongs_ChucVuMaCV",
                table: "HopDongs",
                column: "ChucVuMaCV");

            migrationBuilder.CreateIndex(
                name: "IX_HopDongs_LuongHeSoLuong",
                table: "HopDongs",
                column: "LuongHeSoLuong");

            migrationBuilder.CreateIndex(
                name: "IX_HopDongs_PhongBanMaPB",
                table: "HopDongs",
                column: "PhongBanMaPB");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_HopDongMaHD",
                table: "NhanViens",
                column: "HopDongMaHD");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_LuongHeSoLuong",
                table: "NhanViens",
                column: "LuongHeSoLuong");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_PhongBanMaPB",
                table: "NhanViens",
                column: "PhongBanMaPB");

            migrationBuilder.CreateIndex(
                name: "IX_PhuCaps_NhanVienMaNhanVien",
                table: "PhuCaps",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_Taikhoans_NhanVienMaNhanVien",
                table: "Taikhoans",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_ThuongPhats_NhanVienMaNhanVien",
                table: "ThuongPhats",
                column: "NhanVienMaNhanVien");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaoHiems");

            migrationBuilder.DropTable(
                name: "ChamCongs");

            migrationBuilder.DropTable(
                name: "ctChucVus");

            migrationBuilder.DropTable(
                name: "PhuCaps");

            migrationBuilder.DropTable(
                name: "Taikhoans");

            migrationBuilder.DropTable(
                name: "ThuongPhats");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "HopDongs");

            migrationBuilder.DropTable(
                name: "ChucVus");

            migrationBuilder.DropTable(
                name: "Luongs");

            migrationBuilder.DropTable(
                name: "PhongBans");
        }
    }
}
