using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sabzishop.Migrations
{
    public partial class _15855 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Basket_AspNetUsers_userid",
                table: "Basket");

            migrationBuilder.DropForeignKey(
                name: "FK_Basket_Products_Productsid",
                table: "Basket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Basket",
                table: "Basket");

            migrationBuilder.RenameTable(
                name: "Basket",
                newName: "basket");

            migrationBuilder.RenameIndex(
                name: "IX_Basket_userid",
                table: "basket",
                newName: "IX_basket_userid");

            migrationBuilder.RenameIndex(
                name: "IX_Basket_Productsid",
                table: "basket",
                newName: "IX_basket_Productsid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_basket",
                table: "basket",
                column: "id");

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 1L,
                column: "now",
                value: new DateTime(2022, 5, 1, 10, 25, 54, 968, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 2L,
                column: "now",
                value: new DateTime(2022, 5, 1, 10, 25, 54, 973, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 3L,
                column: "now",
                value: new DateTime(2022, 5, 1, 10, 25, 54, 973, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 4L,
                column: "now",
                value: new DateTime(2022, 5, 1, 10, 25, 54, 973, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Descount",
                keyColumn: "id",
                keyValue: 5L,
                column: "now",
                value: new DateTime(2022, 5, 1, 10, 25, 54, 973, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.AddForeignKey(
                name: "FK_basket_AspNetUsers_userid",
                table: "basket",
                column: "userid",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_basket_Products_Productsid",
                table: "basket",
                column: "Productsid",
                principalTable: "Products",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_basket_AspNetUsers_userid",
                table: "basket");

            migrationBuilder.DropForeignKey(
                name: "FK_basket_Products_Productsid",
                table: "basket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_basket",
                table: "basket");

            migrationBuilder.RenameTable(
                name: "basket",
                newName: "Basket");

            migrationBuilder.RenameIndex(
                name: "IX_basket_userid",
                table: "Basket",
                newName: "IX_Basket_userid");

            migrationBuilder.RenameIndex(
                name: "IX_basket_Productsid",
                table: "Basket",
                newName: "IX_Basket_Productsid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Basket",
                table: "Basket",
                column: "id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Basket_AspNetUsers_userid",
                table: "Basket",
                column: "userid",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Basket_Products_Productsid",
                table: "Basket",
                column: "Productsid",
                principalTable: "Products",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
