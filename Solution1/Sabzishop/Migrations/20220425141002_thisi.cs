using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sabzishop.Migrations
{
    public partial class thisi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 1L,
                column: "now",
                value: new DateTime(2022, 4, 25, 18, 40, 1, 246, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 2L,
                column: "now",
                value: new DateTime(2022, 4, 25, 18, 40, 1, 251, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 3L,
                column: "now",
                value: new DateTime(2022, 4, 25, 18, 40, 1, 251, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 4L,
                column: "now",
                value: new DateTime(2022, 4, 25, 18, 40, 1, 251, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 5L,
                column: "now",
                value: new DateTime(2022, 4, 25, 18, 40, 1, 251, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4L,
                column: "descountid",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7L,
                column: "descountid",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8L,
                column: "descountid",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10L,
                column: "descountid",
                value: 4L);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11L,
                column: "descountid",
                value: 5L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 1L,
                column: "now",
                value: new DateTime(2022, 4, 25, 18, 31, 24, 664, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 2L,
                column: "now",
                value: new DateTime(2022, 4, 25, 18, 31, 24, 679, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 3L,
                column: "now",
                value: new DateTime(2022, 4, 25, 18, 31, 24, 679, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 4L,
                column: "now",
                value: new DateTime(2022, 4, 25, 18, 31, 24, 679, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 5L,
                column: "now",
                value: new DateTime(2022, 4, 25, 18, 31, 24, 679, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4L,
                column: "descountid",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7L,
                column: "descountid",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8L,
                column: "descountid",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10L,
                column: "descountid",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11L,
                column: "descountid",
                value: 0L);
        }
    }
}
