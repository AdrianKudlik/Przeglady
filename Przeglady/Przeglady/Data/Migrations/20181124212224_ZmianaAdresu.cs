using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Przeglady.Data.Migrations
{
    public partial class ZmianaAdresu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Montaz_Adres_AdresMontazuId",
                table: "Montaz");

            migrationBuilder.DropForeignKey(
                name: "FK_Montaz_Adres_AdresPracowniId",
                table: "Montaz");

            migrationBuilder.DropTable(
                name: "Adres");

            migrationBuilder.DropIndex(
                name: "IX_Montaz_AdresMontazuId",
                table: "Montaz");

            migrationBuilder.DropIndex(
                name: "IX_Montaz_AdresPracowniId",
                table: "Montaz");

            migrationBuilder.DropColumn(
                name: "AdresMontazuId",
                table: "Montaz");

            migrationBuilder.DropColumn(
                name: "AdresPracowniId",
                table: "Montaz");

            migrationBuilder.RenameColumn(
                name: "Zaproszenie",
                table: "Montaz",
                newName: "Wojewodztwo2");

            migrationBuilder.AddColumn<string>(
                name: "Kod",
                table: "Montaz",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kod2",
                table: "Montaz",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Miejscowosc",
                table: "Montaz",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Miejscowosc2",
                table: "Montaz",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ulica",
                table: "Montaz",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ulica2",
                table: "Montaz",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Wojewodztwo",
                table: "Montaz",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kod",
                table: "Montaz");

            migrationBuilder.DropColumn(
                name: "Kod2",
                table: "Montaz");

            migrationBuilder.DropColumn(
                name: "Miejscowosc",
                table: "Montaz");

            migrationBuilder.DropColumn(
                name: "Miejscowosc2",
                table: "Montaz");

            migrationBuilder.DropColumn(
                name: "Ulica",
                table: "Montaz");

            migrationBuilder.DropColumn(
                name: "Ulica2",
                table: "Montaz");

            migrationBuilder.DropColumn(
                name: "Wojewodztwo",
                table: "Montaz");

            migrationBuilder.RenameColumn(
                name: "Wojewodztwo2",
                table: "Montaz",
                newName: "Zaproszenie");

            migrationBuilder.AddColumn<int>(
                name: "AdresMontazuId",
                table: "Montaz",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdresPracowniId",
                table: "Montaz",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Adres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Kod = table.Column<string>(nullable: true),
                    Miejscowosc = table.Column<string>(nullable: true),
                    Ulica = table.Column<string>(nullable: true),
                    Wojewodztwo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adres", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Montaz_AdresMontazuId",
                table: "Montaz",
                column: "AdresMontazuId");

            migrationBuilder.CreateIndex(
                name: "IX_Montaz_AdresPracowniId",
                table: "Montaz",
                column: "AdresPracowniId");

            migrationBuilder.AddForeignKey(
                name: "FK_Montaz_Adres_AdresMontazuId",
                table: "Montaz",
                column: "AdresMontazuId",
                principalTable: "Adres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Montaz_Adres_AdresPracowniId",
                table: "Montaz",
                column: "AdresPracowniId",
                principalTable: "Adres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
