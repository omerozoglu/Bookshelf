using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookshelf.API.DataAccess.Migrations
{
    public partial class inital3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_Id",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Genres_Id",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_Id",
                table: "Books");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 11, 18, 1, 21, 850, DateTimeKind.Utc).AddTicks(9957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 11, 16, 37, 8, 709, DateTimeKind.Utc).AddTicks(1010));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 11, 18, 1, 21, 850, DateTimeKind.Utc).AddTicks(9820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 11, 16, 37, 8, 709, DateTimeKind.Utc).AddTicks(864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "BookUsers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 11, 18, 1, 21, 850, DateTimeKind.Utc).AddTicks(8291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 11, 16, 37, 8, 708, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "BookUsers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 11, 18, 1, 21, 850, DateTimeKind.Utc).AddTicks(8130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 11, 16, 37, 8, 708, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LendDate",
                table: "BookTransactions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 11, 18, 1, 21, 850, DateTimeKind.Utc).AddTicks(6173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 11, 16, 37, 8, 708, DateTimeKind.Utc).AddTicks(7707));

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
                name: "FK_Books_Authors_AuthorID",
                table: "Books",
                column: "AuthorID",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Genres_GenreID",
                table: "Books",
                column: "GenreID",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PublisherID",
                table: "Books",
                column: "PublisherID",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorID",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Genres_GenreID",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PublisherID",
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 11, 16, 37, 8, 709, DateTimeKind.Utc).AddTicks(1010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 11, 18, 1, 21, 850, DateTimeKind.Utc).AddTicks(9957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 11, 16, 37, 8, 709, DateTimeKind.Utc).AddTicks(864),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 11, 18, 1, 21, 850, DateTimeKind.Utc).AddTicks(9820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "BookUsers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 11, 16, 37, 8, 708, DateTimeKind.Utc).AddTicks(9312),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 11, 18, 1, 21, 850, DateTimeKind.Utc).AddTicks(8291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "BookUsers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 11, 16, 37, 8, 708, DateTimeKind.Utc).AddTicks(9147),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 11, 18, 1, 21, 850, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LendDate",
                table: "BookTransactions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 11, 16, 37, 8, 708, DateTimeKind.Utc).AddTicks(7707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 11, 18, 1, 21, 850, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_Id",
                table: "Books",
                column: "Id",
                principalTable: "Authors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Genres_Id",
                table: "Books",
                column: "Id",
                principalTable: "Genres",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_Id",
                table: "Books",
                column: "Id",
                principalTable: "Publishers",
                principalColumn: "Id");
        }
    }
}
