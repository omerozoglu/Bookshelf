using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookshelf.API.DataAccess.Migrations
{
    public partial class AddBookUserBookshelfContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookUsers_Books_BookId",
                table: "BookUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_BookUsers_Users_UserId",
                table: "BookUsers");

            migrationBuilder.DropIndex(
                name: "IX_BookUsers_BookId",
                table: "BookUsers");

            migrationBuilder.DropIndex(
                name: "IX_BookUsers_UserId",
                table: "BookUsers");

            migrationBuilder.AddColumn<int>(
                name: "BookID",
                table: "BookUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "BookUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BookUsers_BookID",
                table: "BookUsers",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_BookUsers_UserID",
                table: "BookUsers",
                column: "UserID");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookUsers_Books_BookID",
                table: "BookUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_BookUsers_Users_UserID",
                table: "BookUsers");

            migrationBuilder.DropIndex(
                name: "IX_BookUsers_BookID",
                table: "BookUsers");

            migrationBuilder.DropIndex(
                name: "IX_BookUsers_UserID",
                table: "BookUsers");

            migrationBuilder.DropColumn(
                name: "BookID",
                table: "BookUsers");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "BookUsers");

            migrationBuilder.CreateIndex(
                name: "IX_BookUsers_BookId",
                table: "BookUsers",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookUsers_UserId",
                table: "BookUsers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookUsers_Books_BookId",
                table: "BookUsers",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookUsers_Users_UserId",
                table: "BookUsers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
