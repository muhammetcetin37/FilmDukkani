using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Film.DAL.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adresler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdresTip = table.Column<int>(type: "int", nullable: false),
                    SehirAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IlceAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CaddeSokak = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DısKapiNo = table.Column<int>(type: "int", nullable: false),
                    IcKapiNo = table.Column<int>(type: "int", nullable: false),
                    KargoId = table.Column<int>(type: "int", nullable: false),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TcNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmlerKategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmlerId = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    PaketId = table.Column<int>(type: "int", nullable: false),
                    SepetId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmlerKategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kargo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KargoAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KargoTel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kargo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paketler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UyelikModeli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degisim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AylikFilmSayisi = table.Column<int>(type: "int", nullable: false),
                    AylikUcret = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paketler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sepet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SepeteEklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sepet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tedarikciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gsm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tedarikciler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uyeler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TcNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gsm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdresId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyeler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uyeler_Adresler_AdresId",
                        column: x => x.AdresId,
                        principalTable: "Adresler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Filmler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yonetmen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oyuncular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeknikOzellikler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YapimYili = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SesOzellikleri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltYazilari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AldigiOduller = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BarkodNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TedarikciId = table.Column<int>(type: "int", nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filmler_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Filmler_Tedarikciler_TedarikciId",
                        column: x => x.TedarikciId,
                        principalTable: "Tedarikciler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filmler_KategoriId",
                table: "Filmler",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Filmler_TedarikciId",
                table: "Filmler",
                column: "TedarikciId");

            migrationBuilder.CreateIndex(
                name: "IX_Uyeler_AdresId",
                table: "Uyeler",
                column: "AdresId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmler");

            migrationBuilder.DropTable(
                name: "FilmlerKategori");

            migrationBuilder.DropTable(
                name: "Kargo");

            migrationBuilder.DropTable(
                name: "Paketler");

            migrationBuilder.DropTable(
                name: "Sepet");

            migrationBuilder.DropTable(
                name: "Uyeler");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Tedarikciler");

            migrationBuilder.DropTable(
                name: "Adresler");
        }
    }
}
