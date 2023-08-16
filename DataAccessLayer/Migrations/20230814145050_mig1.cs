using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calisanlars",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hizmetleri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kazanc = table.Column<int>(type: "int", nullable: false),
                    Maas = table.Column<int>(type: "int", nullable: false),
                    Telefon = table.Column<int>(type: "int", nullable: false),
                    Tatil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senedir = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calisanlars", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Hakkimizdas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bilgi1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bilgi2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakkimizdas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Hizmetlers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Turu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dakikasi = table.Column<int>(type: "int", nullable: false),
                    Sorumlu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyati = table.Column<int>(type: "int", nullable: false),
                    Bilgisi1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bilgisi2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto3 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hizmetlers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Musterilers",
                columns: table => new
                {
                    Adi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Randevusu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GecmisRandevu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Harcama = table.Column<int>(type: "int", nullable: false),
                    Telefon = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musterilers", x => x.Adi);
                });

            migrationBuilder.CreateTable(
                name: "Randevus",
                columns: table => new
                {
                    Saat = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HizmetTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HizmetCalisan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Musteri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Musno = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<int>(type: "int", nullable: false),
                    Aktivite = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevus", x => x.Saat);
                });

            migrationBuilder.CreateTable(
                name: "Sube1s",
                columns: table => new
                {
                    Telefon1 = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Konum1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ca1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hi1 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sube1s", x => x.Telefon1);
                });

            migrationBuilder.CreateTable(
                name: "Sube2s",
                columns: table => new
                {
                    Telefon2 = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Konum2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ca2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hi2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sube2s", x => x.Telefon2);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calisanlars");

            migrationBuilder.DropTable(
                name: "Hakkimizdas");

            migrationBuilder.DropTable(
                name: "Hizmetlers");

            migrationBuilder.DropTable(
                name: "Musterilers");

            migrationBuilder.DropTable(
                name: "Randevus");

            migrationBuilder.DropTable(
                name: "Sube1s");

            migrationBuilder.DropTable(
                name: "Sube2s");
        }
    }
}
