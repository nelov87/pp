using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace INStudio.Migrations
{
    public partial class InitialForThis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_INMedias_ImageId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AboutSkilsSections");

            migrationBuilder.DropTable(
                name: "Carousels");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "GalleryINMedias");

            migrationBuilder.DropTable(
                name: "INMediaCategories");

            migrationBuilder.DropTable(
                name: "INServices");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "PostCategories");

            migrationBuilder.DropTable(
                name: "Skils");

            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "INMedias");

            migrationBuilder.DropTable(
                name: "MediaTypes");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gallerys",
                table: "Gallerys");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Gallerys");

            migrationBuilder.RenameTable(
                name: "Gallerys",
                newName: "Galleries");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Galleries",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Settings",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Galleries",
                table: "Galleries",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Url = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GalleryImages",
                columns: table => new
                {
                    GalleryId = table.Column<string>(type: "text", nullable: false),
                    ImageId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryImages", x => new { x.GalleryId, x.ImageId });
                    table.ForeignKey(
                        name: "FK_GalleryImages_Galleries_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Galleries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GalleryImages_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Content = table.Column<string>(type: "text", nullable: true),
                    ImageId = table.Column<string>(type: "text", nullable: true),
                    GalleryId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pages_Galleries_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Galleries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pages_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Partniors",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Link = table.Column<string>(type: "text", nullable: true),
                    ImageId = table.Column<string>(type: "text", nullable: true),
                    GaleryId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partniors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partniors_Galleries_GaleryId",
                        column: x => x.GaleryId,
                        principalTable: "Galleries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partniors_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    GalleryId = table.Column<string>(type: "text", nullable: true),
                    ImageId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Galleries_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Galleries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GalleryImages_ImageId",
                table: "GalleryImages",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Pages_GalleryId",
                table: "Pages",
                column: "GalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_Pages_ImageId",
                table: "Pages",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Partniors_GaleryId",
                table: "Partniors",
                column: "GaleryId");

            migrationBuilder.CreateIndex(
                name: "IX_Partniors_ImageId",
                table: "Partniors",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_GalleryId",
                table: "Projects",
                column: "GalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ImageId",
                table: "Projects",
                column: "ImageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GalleryImages");

            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.DropTable(
                name: "Partniors");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Galleries",
                table: "Galleries");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Settings");

            migrationBuilder.RenameTable(
                name: "Galleries",
                newName: "Gallerys");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Gallerys",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageId",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Gallerys",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gallerys",
                table: "Gallerys",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MediaTypes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    PageId = table.Column<string>(type: "text", nullable: true),
                    Time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "INMedias",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Path = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    TypeId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_INMedias_MediaTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "MediaTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AboutSkilsSections",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ImageId = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    VideoId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutSkilsSections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutSkilsSections_INMedias_ImageId",
                        column: x => x.ImageId,
                        principalTable: "INMedias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AboutSkilsSections_INMedias_VideoId",
                        column: x => x.VideoId,
                        principalTable: "INMedias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: true),
                    ComentsIsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateEdited = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    GalleryId = table.Column<string>(type: "text", nullable: true),
                    PostImageId = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogPosts_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlogPosts_Gallerys_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Gallerys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlogPosts_INMedias_PostImageId",
                        column: x => x.PostImageId,
                        principalTable: "INMedias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carousels",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Ative = table.Column<bool>(type: "boolean", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Link = table.Column<string>(type: "text", nullable: true),
                    MediaId = table.Column<string>(type: "text", nullable: true),
                    Number = table.Column<int>(type: "integer", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carousels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carousels_INMedias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "INMedias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GalleryINMedias",
                columns: table => new
                {
                    GalleryId = table.Column<string>(type: "text", nullable: false),
                    INMediaId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryINMedias", x => new { x.GalleryId, x.INMediaId });
                    table.ForeignKey(
                        name: "FK_GalleryINMedias_Gallerys_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Gallerys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GalleryINMedias_INMedias_INMediaId",
                        column: x => x.INMediaId,
                        principalTable: "INMedias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "INMediaCategories",
                columns: table => new
                {
                    INMediaId = table.Column<string>(type: "text", nullable: false),
                    CategoryId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INMediaCategories", x => new { x.INMediaId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_INMediaCategories_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_INMediaCategories_INMedias_INMediaId",
                        column: x => x.INMediaId,
                        principalTable: "INMedias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "INServices",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ImageId = table.Column<string>(type: "text", nullable: true),
                    Link = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_INServices_INMedias_ImageId",
                        column: x => x.ImageId,
                        principalTable: "INMedias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Skils",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true),
                    ImageId = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skils", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skils_INMedias_ImageId",
                        column: x => x.ImageId,
                        principalTable: "INMedias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: true),
                    BlogPostId = table.Column<string>(type: "text", nullable: true),
                    CommentText = table.Column<string>(type: "text", nullable: true),
                    Visable = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostCategories",
                columns: table => new
                {
                    BlogPostId = table.Column<string>(type: "text", nullable: false),
                    CategoryId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCategories", x => new { x.BlogPostId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_PostCategories_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostCategories_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutSkilsSections_ImageId",
                table: "AboutSkilsSections",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutSkilsSections_VideoId",
                table: "AboutSkilsSections",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_AppUserId",
                table: "BlogPosts",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_GalleryId",
                table: "BlogPosts",
                column: "GalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_PostImageId",
                table: "BlogPosts",
                column: "PostImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Carousels_MediaId",
                table: "Carousels",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AppUserId",
                table: "Comments",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogPostId",
                table: "Comments",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_GalleryINMedias_INMediaId",
                table: "GalleryINMedias",
                column: "INMediaId");

            migrationBuilder.CreateIndex(
                name: "IX_INMediaCategories_CategoryId",
                table: "INMediaCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_INMedias_TypeId",
                table: "INMedias",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_INServices_ImageId",
                table: "INServices",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_PostCategories_CategoryId",
                table: "PostCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Skils_ImageId",
                table: "Skils",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_INMedias_ImageId",
                table: "AspNetUsers",
                column: "ImageId",
                principalTable: "INMedias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
