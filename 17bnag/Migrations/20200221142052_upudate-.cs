using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _17bnag.Migrations
{
    public partial class upudate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HelpRelease",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 10, nullable: false),
                    Boyd = table.Column<string>(maxLength: 21113, nullable: false),
                    KeyWord = table.Column<string>(nullable: false),
                    Resort = table.Column<string>(nullable: true),
                    Moneys = table.Column<string>(nullable: false),
                    PublishDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HelpRelease", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HelpRelease");
        }
    }
}
