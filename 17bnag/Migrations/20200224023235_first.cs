using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _17bnag.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Keyword",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keyword", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogOnUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogOnUserName = table.Column<string>(maxLength: 8, nullable: false),
                    LogOnUserPassword = table.Column<string>(maxLength: 20, nullable: false),
                    LogOnUserVerification = table.Column<string>(maxLength: 4, nullable: false),
                    RememberMe = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogOnUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HelpRelease",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 10, nullable: false),
                    Body = table.Column<string>(maxLength: 21113, nullable: false),
                    KeyWordId = table.Column<int>(nullable: false),
                    Resort = table.Column<string>(nullable: true),
                    Moneys = table.Column<string>(nullable: false),
                    PublishDateTime = table.Column<DateTime>(nullable: false),
                    AuthorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HelpRelease", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HelpRelease_LogOnUser_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "LogOnUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HelpRelease_Keyword_KeyWordId",
                        column: x => x.KeyWordId,
                        principalTable: "Keyword",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PublishArticles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(nullable: true),
                    Body = table.Column<string>(maxLength: 2312412, nullable: false),
                    keywordsId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 10, nullable: false),
                    PublishTime = table.Column<DateTime>(nullable: false),
                    Digest = table.Column<string>(maxLength: 115, nullable: false),
                    Series = table.Column<string>(nullable: true),
                    UsedAds = table.Column<string>(nullable: true),
                    Interlinkage = table.Column<string>(nullable: false),
                    text = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublishArticles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PublishArticles_LogOnUser_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "LogOnUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PublishArticles_Keyword_keywordsId",
                        column: x => x.keywordsId,
                        principalTable: "Keyword",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HelpRelease_AuthorId",
                table: "HelpRelease",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_HelpRelease_KeyWordId",
                table: "HelpRelease",
                column: "KeyWordId");

            migrationBuilder.CreateIndex(
                name: "IX_PublishArticles_AuthorId",
                table: "PublishArticles",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_PublishArticles_keywordsId",
                table: "PublishArticles",
                column: "keywordsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HelpRelease");

            migrationBuilder.DropTable(
                name: "PublishArticles");

            migrationBuilder.DropTable(
                name: "LogOnUser");

            migrationBuilder.DropTable(
                name: "Keyword");
        }
    }
}
