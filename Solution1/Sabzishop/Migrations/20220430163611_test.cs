using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sabzishop.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 1L,
                column: "now",
                value: new DateTime(2022, 4, 30, 21, 6, 8, 791, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 2L,
                column: "now",
                value: new DateTime(2022, 4, 30, 21, 6, 8, 815, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 3L,
                column: "now",
                value: new DateTime(2022, 4, 30, 21, 6, 8, 815, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 4L,
                column: "now",
                value: new DateTime(2022, 4, 30, 21, 6, 8, 815, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 5L,
                column: "now",
                value: new DateTime(2022, 4, 30, 21, 6, 8, 815, DateTimeKind.Local).AddTicks(7747));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 1L,
                column: "now",
                value: new DateTime(2022, 4, 30, 10, 0, 21, 85, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 2L,
                column: "now",
                value: new DateTime(2022, 4, 30, 10, 0, 21, 88, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 3L,
                column: "now",
                value: new DateTime(2022, 4, 30, 10, 0, 21, 88, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 4L,
                column: "now",
                value: new DateTime(2022, 4, 30, 10, 0, 21, 88, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 5L,
                column: "now",
                value: new DateTime(2022, 4, 30, 10, 0, 21, 88, DateTimeKind.Local).AddTicks(1477));
        }
    }
}
