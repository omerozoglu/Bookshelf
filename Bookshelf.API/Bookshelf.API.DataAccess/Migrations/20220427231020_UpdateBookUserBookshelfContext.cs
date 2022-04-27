using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookshelf.API.DataAccess.Migrations
{
    public partial class UpdateBookUserBookshelfContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookUsers_Books_BookID",
                table: "BookUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_BookUsers_Users_UserID",
                table: "BookUsers");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "BookUsers",
                newName: "UserBookID");

            migrationBuilder.RenameColumn(
                name: "BookID",
                table: "BookUsers",
                newName: "BookUserID");

            migrationBuilder.RenameIndex(
                name: "IX_BookUsers_UserID",
                table: "BookUsers",
                newName: "IX_BookUsers_UserBookID");

            migrationBuilder.RenameIndex(
                name: "IX_BookUsers_BookID",
                table: "BookUsers",
                newName: "IX_BookUsers_BookUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookUsers_Books_BookUserID",
                table: "BookUsers",
                column: "BookUserID",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookUsers_Users_UserBookID",
                table: "BookUsers",
                column: "UserBookID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookUsers_Books_BookUserID",
                table: "BookUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_BookUsers_Users_UserBookID",
                table: "BookUsers");

            migrationBuilder.RenameColumn(
                name: "UserBookID",
                table: "BookUsers",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "BookUserID",
                table: "BookUsers",
                newName: "BookID");

            migrationBuilder.RenameIndex(
                name: "IX_BookUsers_UserBookID",
                table: "BookUsers",
                newName: "IX_BookUsers_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_BookUsers_BookUserID",
                table: "BookUsers",
                newName: "IX_BookUsers_BookID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookUsers_Books_BookID",
                table: "BookUsers",
                column: "BookID",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookUsers_Users_UserID",
                table: "BookUsers",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
