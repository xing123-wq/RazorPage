using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _17bnag.Migrations
{
    public partial class frist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticleKeyword",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleKeyword", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Keywords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keywords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 8, nullable: false),
                    Password = table.Column<string>(maxLength: 20, nullable: false),
                    LogOnUserVerification = table.Column<string>(maxLength: 4, nullable: false),
                    RememberMe = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HelpRelease",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 10, nullable: false),
                    Body = table.Column<string>(maxLength: 21113, nullable: false),
                    Resort = table.Column<string>(nullable: true),
                    Moneys = table.Column<string>(nullable: false),
                    PublishDateTime = table.Column<DateTime>(nullable: false),
                    AuthorId = table.Column<int>(nullable: true),
                    KeywordId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HelpRelease", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HelpRelease_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HelpRelease_Keywords_KeywordId",
                        column: x => x.KeywordId,
                        principalTable: "Keywords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PublishArticles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(nullable: true),
                    Body = table.Column<string>(maxLength: 2312412, nullable: false),
                    Title = table.Column<string>(maxLength: 10, nullable: false),
                    PublishTime = table.Column<DateTime>(nullable: false),
                    Digest = table.Column<string>(maxLength: 115, nullable: false),
                    Series = table.Column<string>(nullable: true),
                    UsedAds = table.Column<string>(nullable: true),
                    Interlinkage = table.Column<string>(nullable: false),
                    text = table.Column<string>(nullable: false),
                    ArticleKeywordId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublishArticles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PublishArticles_ArticleKeyword_ArticleKeywordId",
                        column: x => x.ArticleKeywordId,
                        principalTable: "ArticleKeyword",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PublishArticles_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Map",
                columns: table => new
                {
                    helperId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HelpId = table.Column<int>(nullable: true),
                    KeywordId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Map", x => x.helperId);
                    table.ForeignKey(
                        name: "FK_Map_HelpRelease_HelpId",
                        column: x => x.HelpId,
                        principalTable: "HelpRelease",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Map_Keywords_KeywordId",
                        column: x => x.KeywordId,
                        principalTable: "Keywords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleMap",
                columns: table => new
                {
                    PublishId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublishArticleId = table.Column<int>(nullable: true),
                    ArticleKeywordId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleMap", x => x.PublishId);
                    table.ForeignKey(
                        name: "FK_ArticleMap_ArticleKeyword_ArticleKeywordId",
                        column: x => x.ArticleKeywordId,
                        principalTable: "ArticleKeyword",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleMap_PublishArticles_PublishArticleId",
                        column: x => x.PublishArticleId,
                        principalTable: "PublishArticles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleMap_ArticleKeywordId",
                table: "ArticleMap",
                column: "ArticleKeywordId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleMap_PublishArticleId",
                table: "ArticleMap",
                column: "PublishArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_HelpRelease_AuthorId",
                table: "HelpRelease",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_HelpRelease_KeywordId",
                table: "HelpRelease",
                column: "KeywordId");

            migrationBuilder.CreateIndex(
                name: "IX_Map_HelpId",
                table: "Map",
                column: "HelpId");

            migrationBuilder.CreateIndex(
                name: "IX_Map_KeywordId",
                table: "Map",
                column: "KeywordId");

            migrationBuilder.CreateIndex(
                name: "IX_PublishArticles_ArticleKeywordId",
                table: "PublishArticles",
                column: "ArticleKeywordId");

            migrationBuilder.CreateIndex(
                name: "IX_PublishArticles_AuthorId",
                table: "PublishArticles",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleMap");

            migrationBuilder.DropTable(
                name: "Map");

            migrationBuilder.DropTable(
                name: "PublishArticles");

            migrationBuilder.DropTable(
                name: "HelpRelease");

            migrationBuilder.DropTable(
                name: "ArticleKeyword");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Keywords");
        }
    }
}
