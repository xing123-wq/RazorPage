using Microsoft.EntityFrameworkCore.Migrations;

namespace _17bnag.Migrations
{
    public partial class thirdly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HelpRelease_Users_AuthorUserId",
                table: "HelpRelease");

            migrationBuilder.DropForeignKey(
                name: "FK_HelpRelease_Keywords_KeywordId",
                table: "HelpRelease");

            migrationBuilder.DropForeignKey(
                name: "FK_PublishArticles_Users_AuthorUserId",
                table: "PublishArticles");

            migrationBuilder.DropForeignKey(
                name: "FK_PublishArticles_Keywords_keywordsKeywordId",
                table: "PublishArticles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Keywords",
                table: "Keywords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HelpRelease",
                table: "HelpRelease");

            migrationBuilder.DropIndex(
                name: "IX_HelpRelease_AuthorUserId",
                table: "HelpRelease");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PublishArticles",
                table: "PublishArticles");

            migrationBuilder.DropIndex(
                name: "IX_PublishArticles_AuthorUserId",
                table: "PublishArticles");

            migrationBuilder.DropIndex(
                name: "IX_PublishArticles_keywordsKeywordId",
                table: "PublishArticles");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "KeywordId",
                table: "Keywords");

            migrationBuilder.DropColumn(
                name: "HelpReleaseId",
                table: "HelpRelease");

            migrationBuilder.DropColumn(
                name: "AuthorUserId",
                table: "HelpRelease");

            migrationBuilder.DropColumn(
                name: "AuthorUserId",
                table: "PublishArticles");

            migrationBuilder.DropColumn(
                name: "keywordsKeywordId",
                table: "PublishArticles");

            migrationBuilder.RenameTable(
                name: "PublishArticles",
                newName: "PublishArticle");

            migrationBuilder.RenameColumn(
                name: "KeywordId",
                table: "HelpRelease",
                newName: "KeyWordId");

            migrationBuilder.RenameIndex(
                name: "IX_HelpRelease_KeywordId",
                table: "HelpRelease",
                newName: "IX_HelpRelease_KeyWordId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Users",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Keywords",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "HelpRelease",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "HelpRelease",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "PublishArticle",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "keywordsId",
                table: "PublishArticle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Keywords",
                table: "Keywords",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HelpRelease",
                table: "HelpRelease",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PublishArticle",
                table: "PublishArticle",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_HelpRelease_AuthorId",
                table: "HelpRelease",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_PublishArticle_AuthorId",
                table: "PublishArticle",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_PublishArticle_keywordsId",
                table: "PublishArticle",
                column: "keywordsId");

            migrationBuilder.AddForeignKey(
                name: "FK_HelpRelease_Users_AuthorId",
                table: "HelpRelease",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HelpRelease_Keywords_KeyWordId",
                table: "HelpRelease",
                column: "KeyWordId",
                principalTable: "Keywords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PublishArticle_Users_AuthorId",
                table: "PublishArticle",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PublishArticle_Keywords_keywordsId",
                table: "PublishArticle",
                column: "keywordsId",
                principalTable: "Keywords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HelpRelease_Users_AuthorId",
                table: "HelpRelease");

            migrationBuilder.DropForeignKey(
                name: "FK_HelpRelease_Keywords_KeyWordId",
                table: "HelpRelease");

            migrationBuilder.DropForeignKey(
                name: "FK_PublishArticle_Users_AuthorId",
                table: "PublishArticle");

            migrationBuilder.DropForeignKey(
                name: "FK_PublishArticle_Keywords_keywordsId",
                table: "PublishArticle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Keywords",
                table: "Keywords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HelpRelease",
                table: "HelpRelease");

            migrationBuilder.DropIndex(
                name: "IX_HelpRelease_AuthorId",
                table: "HelpRelease");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PublishArticle",
                table: "PublishArticle");

            migrationBuilder.DropIndex(
                name: "IX_PublishArticle_AuthorId",
                table: "PublishArticle");

            migrationBuilder.DropIndex(
                name: "IX_PublishArticle_keywordsId",
                table: "PublishArticle");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Keywords");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "HelpRelease");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "HelpRelease");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "PublishArticle");

            migrationBuilder.DropColumn(
                name: "keywordsId",
                table: "PublishArticle");

            migrationBuilder.RenameTable(
                name: "PublishArticle",
                newName: "PublishArticles");

            migrationBuilder.RenameColumn(
                name: "KeyWordId",
                table: "HelpRelease",
                newName: "KeywordId");

            migrationBuilder.RenameIndex(
                name: "IX_HelpRelease_KeyWordId",
                table: "HelpRelease",
                newName: "IX_HelpRelease_KeywordId");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "KeywordId",
                table: "Keywords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HelpReleaseId",
                table: "HelpRelease",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AuthorUserId",
                table: "HelpRelease",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuthorUserId",
                table: "PublishArticles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "keywordsKeywordId",
                table: "PublishArticles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Keywords",
                table: "Keywords",
                column: "KeywordId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HelpRelease",
                table: "HelpRelease",
                column: "HelpReleaseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PublishArticles",
                table: "PublishArticles",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_HelpRelease_AuthorUserId",
                table: "HelpRelease",
                column: "AuthorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PublishArticles_AuthorUserId",
                table: "PublishArticles",
                column: "AuthorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PublishArticles_keywordsKeywordId",
                table: "PublishArticles",
                column: "keywordsKeywordId");

            migrationBuilder.AddForeignKey(
                name: "FK_HelpRelease_Users_AuthorUserId",
                table: "HelpRelease",
                column: "AuthorUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HelpRelease_Keywords_KeywordId",
                table: "HelpRelease",
                column: "KeywordId",
                principalTable: "Keywords",
                principalColumn: "KeywordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PublishArticles_Users_AuthorUserId",
                table: "PublishArticles",
                column: "AuthorUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PublishArticles_Keywords_keywordsKeywordId",
                table: "PublishArticles",
                column: "keywordsKeywordId",
                principalTable: "Keywords",
                principalColumn: "KeywordId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
