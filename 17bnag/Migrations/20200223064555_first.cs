using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _17bnag.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "onUsers",
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
                    table.PrimaryKey("PK_onUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegisterUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 8, nullable: false),
                    Password = table.Column<string>(maxLength: 20, nullable: false),
                    ValidatePassword = table.Column<string>(nullable: false),
                    inviter = table.Column<string>(maxLength: 8, nullable: false),
                    Invitationcode = table.Column<string>(maxLength: 4, nullable: false),
                    VerificationCode = table.Column<string>(maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterUser", x => x.Id);
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
                    AuthorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HelpRelease", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HelpRelease_onUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "onUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublishDateTime = table.Column<DateTime>(nullable: false),
                    AuthorId = table.Column<int>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_RegisterUser_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "RegisterUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "problems",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PublishDateTime = table.Column<DateTime>(nullable: false),
                    Body = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    AuthorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_problems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_problems_RegisterUser_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "RegisterUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "keywords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ArticlesId = table.Column<int>(nullable: true),
                    HelpReleaseId = table.Column<int>(nullable: true),
                    ProblemId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_keywords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_keywords_Articles_ArticlesId",
                        column: x => x.ArticlesId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_keywords_HelpRelease_HelpReleaseId",
                        column: x => x.HelpReleaseId,
                        principalTable: "HelpRelease",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_keywords_problems_ProblemId",
                        column: x => x.ProblemId,
                        principalTable: "problems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_AuthorId",
                table: "Articles",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_HelpRelease_AuthorId",
                table: "HelpRelease",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_keywords_ArticlesId",
                table: "keywords",
                column: "ArticlesId");

            migrationBuilder.CreateIndex(
                name: "IX_keywords_HelpReleaseId",
                table: "keywords",
                column: "HelpReleaseId");

            migrationBuilder.CreateIndex(
                name: "IX_keywords_ProblemId",
                table: "keywords",
                column: "ProblemId");

            migrationBuilder.CreateIndex(
                name: "IX_problems_AuthorId",
                table: "problems",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "keywords");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "HelpRelease");

            migrationBuilder.DropTable(
                name: "problems");

            migrationBuilder.DropTable(
                name: "onUsers");

            migrationBuilder.DropTable(
                name: "RegisterUser");
        }
    }
}
