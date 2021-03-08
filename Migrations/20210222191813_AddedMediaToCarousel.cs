using Microsoft.EntityFrameworkCore.Migrations;

namespace INStudio.Migrations
{
    public partial class AddedMediaToCarousel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MediaId",
                table: "Carousels",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carousels_MediaId",
                table: "Carousels",
                column: "MediaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carousels_INMedias_MediaId",
                table: "Carousels",
                column: "MediaId",
                principalTable: "INMedias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carousels_INMedias_MediaId",
                table: "Carousels");

            migrationBuilder.DropIndex(
                name: "IX_Carousels_MediaId",
                table: "Carousels");

            migrationBuilder.DropColumn(
                name: "MediaId",
                table: "Carousels");
        }
    }
}
