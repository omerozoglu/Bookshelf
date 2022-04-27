using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookshelf.API.DataAccess.Migrations
{
    public partial class Update2BookUserBookshelfContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookUsers_Users_UserBookID",
                table: "BookUsers");

            migrationBuilder.DropIndex(
                name: "IX_BookUsers_UserBookID",
                table: "BookUsers");

            migrationBuilder.DropColumn(
                name: "UserBookID",
                table: "BookUsers");

            migrationBuilder.CreateIndex(
                name: "IX_BookUsers_UserId",
                table: "BookUsers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookUsers_Users_UserId",
                table: "BookUsers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookUsers_Users_UserId",
                table: "BookUsers");

            migrationBuilder.DropIndex(
                name: "IX_BookUsers_UserId",
                table: "BookUsers");

            migrationBuilder.AddColumn<int>(
                name: "UserBookID",
                table: "BookUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BookUsers_UserBookID",
                table: "BookUsers",
                column: "UserBookID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookUsers_Users_UserBookID",
                table: "BookUsers",
                column: "UserBookID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
