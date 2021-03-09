using Microsoft.EntityFrameworkCore.Migrations;

namespace INStudio.Migrations
{
    public partial class ProecAddedIdiis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Images_ImageId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "ImageId",
                table: "Projects",
                newName: "imageId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_ImageId",
                table: "Projects",
                newName: "IX_Projects_imageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Images_imageId",
                table: "Projects",
                column: "imageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Images_imageId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "imageId",
                table: "Projects",
                newName: "ImageId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_imageId",
                table: "Projects",
                newName: "IX_Projects_ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Images_ImageId",
                table: "Projects",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
