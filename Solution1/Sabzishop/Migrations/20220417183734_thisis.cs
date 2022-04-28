using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sabzishop.Migrations
{
    public partial class thisis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Descount",
                columns: new[] { "id", "enddes", "now", "pricedes", "proid" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 5, 2, 5, 10, 20, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 17, 23, 7, 33, 80, DateTimeKind.Local).AddTicks(6533), 590000m, 4L },
                    { 2L, new DateTime(2022, 5, 1, 5, 10, 20, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 17, 23, 7, 33, 104, DateTimeKind.Local).AddTicks(4445), 490000m, 7L },
                    { 3L, new DateTime(2022, 5, 3, 5, 10, 20, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 17, 23, 7, 33, 104, DateTimeKind.Local).AddTicks(4490), 390000m, 8L },
                    { 4L, new DateTime(2022, 5, 4, 5, 10, 20, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 17, 23, 7, 33, 104, DateTimeKind.Local).AddTicks(4497), 490000m, 10L },
                    { 5L, new DateTime(2022, 5, 2, 5, 10, 20, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 17, 23, 7, 33, 104, DateTimeKind.Local).AddTicks(4501), 990000m, 11L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 5L);
        }
    }
}
