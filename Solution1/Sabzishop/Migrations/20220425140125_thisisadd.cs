using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sabzishop.Migrations
{
    public partial class thisisadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 1L,
                column: "now",
                value: new DateTime(2022, 4, 17, 23, 7, 33, 80, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 2L,
                column: "now",
                value: new DateTime(2022, 4, 17, 23, 7, 33, 104, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 3L,
                column: "now",
                value: new DateTime(2022, 4, 17, 23, 7, 33, 104, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 4L,
                column: "now",
                value: new DateTime(2022, 4, 17, 23, 7, 33, 104, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 5L,
                column: "now",
                value: new DateTime(2022, 4, 17, 23, 7, 33, 104, DateTimeKind.Local).AddTicks(4501));
        }
    }
}
