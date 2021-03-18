using Microsoft.EntityFrameworkCore.Migrations;

namespace INStudio.Migrations
{
    public partial class PartniorsImageIdAded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GeleryId",
                table: "Partniors",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GeleryId",
                table: "Partniors");
        }
    }
}
