using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookshelf.API.DataAccess.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 11, 16, 37, 8, 709, DateTimeKind.Utc).AddTicks(1010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 11, 16, 31, 27, 121, DateTimeKind.Utc).AddTicks(7722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 11, 16, 37, 8, 709, DateTimeKind.Utc).AddTicks(864),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 11, 16, 31, 27, 121, DateTimeKind.Utc).AddTicks(7565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "BookUsers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 11, 16, 37, 8, 708, DateTimeKind.Utc).AddTicks(9312),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 11, 16, 31, 27, 121, DateTimeKind.Utc).AddTicks(2486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "BookUsers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 11, 16, 37, 8, 708, DateTimeKind.Utc).AddTicks(9147),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 11, 16, 31, 27, 121, DateTimeKind.Utc).AddTicks(2223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LendDate",
                table: "BookTransactions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 11, 16, 37, 8, 708, DateTimeKind.Utc).AddTicks(7707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 11, 16, 31, 27, 121, DateTimeKind.Utc).AddTicks(618));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 11, 16, 31, 27, 121, DateTimeKind.Utc).AddTicks(7722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 11, 16, 37, 8, 709, DateTimeKind.Utc).AddTicks(1010));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 11, 16, 31, 27, 121, DateTimeKind.Utc).AddTicks(7565),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 11, 16, 37, 8, 709, DateTimeKind.Utc).AddTicks(864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "BookUsers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 11, 16, 31, 27, 121, DateTimeKind.Utc).AddTicks(2486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 11, 16, 37, 8, 708, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "BookUsers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 11, 16, 31, 27, 121, DateTimeKind.Utc).AddTicks(2223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 11, 16, 37, 8, 708, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LendDate",
                table: "BookTransactions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 11, 16, 31, 27, 121, DateTimeKind.Utc).AddTicks(618),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 11, 16, 37, 8, 708, DateTimeKind.Utc).AddTicks(7707));
        }
    }
}
