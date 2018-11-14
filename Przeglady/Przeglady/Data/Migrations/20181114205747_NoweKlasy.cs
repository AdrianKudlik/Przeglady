using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Przeglady.Data.Migrations
{
    public partial class NoweKlasy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "Adres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ulica = table.Column<string>(nullable: true),
                    Kod = table.Column<string>(nullable: true),
                    Miejscowosc = table.Column<string>(nullable: true),
                    Wojewodztwo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Montaz",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nazwa = table.Column<string>(nullable: true),
                    Imie = table.Column<string>(nullable: true),
                    Nazwisko = table.Column<string>(nullable: true),
                    AdresPracowniId = table.Column<int>(nullable: true),
                    AdresMontazuId = table.Column<int>(nullable: true),
                    Telefon = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Nip = table.Column<string>(nullable: true),
                    Zaproszenie = table.Column<string>(nullable: true),
                    Gwarancja = table.Column<string>(nullable: true),
                    DataMontazu = table.Column<DateTime>(nullable: false),
                    DataOstatniegoPrzegladu = table.Column<DateTime>(nullable: false),
                    Podreczniki = table.Column<bool>(nullable: false),
                    ODOIA = table.Column<bool>(nullable: false),
                    SIGMA = table.Column<bool>(nullable: false),
                    Uwagi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Montaz", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Montaz_Adres_AdresMontazuId",
                        column: x => x.AdresMontazuId,
                        principalTable: "Adres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Montaz_Adres_AdresPracowniId",
                        column: x => x.AdresPracowniId,
                        principalTable: "Adres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Montaz_AdresMontazuId",
                table: "Montaz",
                column: "AdresMontazuId");

            migrationBuilder.CreateIndex(
                name: "IX_Montaz_AdresPracowniId",
                table: "Montaz",
                column: "AdresPracowniId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Montaz");

            migrationBuilder.DropTable(
                name: "Adres");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
