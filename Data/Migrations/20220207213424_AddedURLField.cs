using Microsoft.EntityFrameworkCore.Migrations;

namespace BookmarksWebApp.Data.Migrations
{
    public partial class AddedURLField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Bookmark",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "URL",
                table: "Bookmark");
        }
    }
}
