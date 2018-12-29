using Microsoft.EntityFrameworkCore.Migrations;

namespace Przeglady.Data.Migrations
{
    public partial class AddLanLng : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Montaz",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Montaz",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Montaz");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Montaz");
        }
    }
}
