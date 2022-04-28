using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sabzishop.Migrations
{
    public partial class thisiAdedDescount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "descountid",
                table: "Products",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Descount",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    now = table.Column<DateTime>(type: "datetime2", nullable: false),
                    enddes = table.Column<DateTime>(type: "datetime2", nullable: false),
                    proid = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descount", x => x.id);
                    table.ForeignKey(
                        name: "FK_Descount_Products_proid",
                        column: x => x.proid,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Descount_proid",
                table: "Descount",
                column: "proid",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Descount");

            migrationBuilder.DropColumn(
                name: "descountid",
                table: "Products");
        }
    }
}
