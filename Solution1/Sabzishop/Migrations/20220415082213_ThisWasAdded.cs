using Microsoft.EntityFrameworkCore.Migrations;

namespace Sabzishop.Migrations
{
    public partial class ThisWasAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "slider",
                columns: new[] { "id", "discription", "title", "undertitle" },
                values: new object[,]
                {
                    { 1L, "این یه نمونه برای شما که هستی ", "تله فیزیون1", "شپولی جونم" },
                    { 2L, "این یه نمونه برای شما که هستی ", "تله فیزیون2", "شپولی جونم" },
                    { 3L, "این یه نمونه برای شما که هستی ", "تله فیزیون3", "شپولی جونم" },
                    { 4L, "این یه نمونه برای شما که هستی ", "4تله فیزیون", "شپولی جونم" },
                    { 5L, "این یه نمونه برای شما که هستی ", "تله فیزیون5", "شپولی جونم" },
                    { 6L, "این یه نمونه برای شما که هستی ", "تله فیزیون6", "شپولی جونم" },
                    { 7L, "این یه نمونه برای شما که هستی ", "تله فیزیون7", "شپولی جونم" },
                    { 8L, "این یه نمونه برای شما که هستی ", "تله فیزیون8", "شپولی جونم" },
                    { 9L, "این یه نمونه برای شما که هستی ", "9 فیزیون", "شپولی جونم" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "slider",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "slider",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "slider",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "slider",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "slider",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "slider",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "slider",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "slider",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "slider",
                keyColumn: "id",
                keyValue: 9L);
        }
    }
}
