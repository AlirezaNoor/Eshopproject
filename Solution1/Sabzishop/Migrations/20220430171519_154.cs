using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sabzishop.Migrations
{
    public partial class _154 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Basket",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tedad = table.Column<long>(type: "bigint", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    proid = table.Column<long>(type: "bigint", nullable: false),
                    Productsid = table.Column<long>(type: "bigint", nullable: true),
                    userid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basket", x => x.id);
                    table.ForeignKey(
                        name: "FK_Basket_AspNetUsers_userid",
                        column: x => x.userid,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Basket_Products_Productsid",
                        column: x => x.Productsid,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 1L,
                column: "now",
                value: new DateTime(2022, 4, 30, 21, 45, 17, 575, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 2L,
                column: "now",
                value: new DateTime(2022, 4, 30, 21, 45, 17, 583, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 3L,
                column: "now",
                value: new DateTime(2022, 4, 30, 21, 45, 17, 583, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 4L,
                column: "now",
                value: new DateTime(2022, 4, 30, 21, 45, 17, 583, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 5L,
                column: "now",
                value: new DateTime(2022, 4, 30, 21, 45, 17, 583, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.CreateIndex(
                name: "IX_Basket_Productsid",
                table: "Basket",
                column: "Productsid");

            migrationBuilder.CreateIndex(
                name: "IX_Basket_userid",
                table: "Basket",
                column: "userid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Basket");

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
    }
}
