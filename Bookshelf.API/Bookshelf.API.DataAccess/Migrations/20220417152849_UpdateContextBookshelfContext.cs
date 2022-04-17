using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookshelf.API.DataAccess.Migrations
{
    public partial class UpdateContextBookshelfContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Author_AuthorID",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Genre_GenreID",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publisher_PublisherID",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorID",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_GenreID",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_PublisherID",
                table: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "Books",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FK_Books_Author_AuthorID",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FK_Books_Genre_GenreID",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FK_Books_Publisher_PublisherID",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Books_FK_Books_Author_AuthorID",
                table: "Books",
                column: "FK_Books_Author_AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_FK_Books_Genre_GenreID",
                table: "Books",
                column: "FK_Books_Genre_GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_FK_Books_Publisher_PublisherID",
                table: "Books",
                column: "FK_Books_Publisher_PublisherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Author_FK_Books_Author_AuthorID",
                table: "Books",
                column: "FK_Books_Author_AuthorID",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Genre_FK_Books_Genre_GenreID",
                table: "Books",
                column: "FK_Books_Genre_GenreID",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publisher_FK_Books_Publisher_PublisherID",
                table: "Books",
                column: "FK_Books_Publisher_PublisherID",
                principalTable: "Publisher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Author_FK_Books_Author_AuthorID",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Genre_FK_Books_Genre_GenreID",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publisher_FK_Books_Publisher_PublisherID",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_FK_Books_Author_AuthorID",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_FK_Books_Genre_GenreID",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_FK_Books_Publisher_PublisherID",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "FK_Books_Author_AuthorID",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "FK_Books_Genre_GenreID",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "FK_Books_Publisher_PublisherID",
                table: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorID",
                table: "Books",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreID",
                table: "Books",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherID",
                table: "Books",
                column: "PublisherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Author_AuthorID",
                table: "Books",
                column: "AuthorID",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Genre_GenreID",
                table: "Books",
                column: "GenreID",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publisher_PublisherID",
                table: "Books",
                column: "PublisherID",
                principalTable: "Publisher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
