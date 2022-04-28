using Microsoft.EntityFrameworkCore.Migrations;

namespace Sabzishop.Migrations
{
    public partial class ThisisAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1L, "گوشی" },
                    { 2L, "لپ تاپ" },
                    { 3L, "تبلت" },
                    { 4L, "هدفون و هدست" },
                    { 5L, "کنسول بازی" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "ISspesial", "categoryid", "discriptio", "instroe", "name", "price" },
                values: new object[,]
                {
                    { 1L, true, 1L, "یک گوشی مناسب وارزان", 4L, "گوشی موبایل Xiaomi Mi 9", 350000m },
                    { 5L, true, 1L, "گوشی آیفون  ", 10L, "گوشی آیفون", 350000m },
                    { 6L, false, 1L, "گوشی شیاموی رد می", 15L, "گوشی شیاموی رد می", 350000m },
                    { 13L, true, 2L, "هدفون حرفه ای گیمینگ Beats ", 15L, "هدفون حرفه ای گیمینگ Beats", 790000m },
                    { 7L, true, 2L, "هدفون حرفه ای گیمینگ Beats ", 15L, "هدفون حرفه ای گیمینگ Beats", 790000m },
                    { 10L, true, 2L, "لپ اپ های زیبا روی ایران", 15L, "لپ تاپ شیامی", 1200000m },
                    { 11L, false, 3L, "تبلت های های زیبا", 15L, "تبلت های زیبا ", 1200000m },
                    { 12L, true, 3L, "تبلت های های زیبا", 15L, "تبلت های آسوز", 1200000m },
                    { 2L, false, 4L, "یک هنسفری مناسب ", 3L, "هندزفری بی سیم Sony", 3800m },
                    { 4L, true, 4L, "هندزفری بلوتوثی بی سیم Xiaomi iBfree ", 15L, "هندزفری بلوتوثی بی سیم Xiaomi iBfree", 790000m },
                    { 9L, false, 4L, "اسپیکر بلوتوثی قابل حمل Anker", 15L, "اسپیکر بلوتوثی قابل حمل Anker", 200000m },
                    { 3L, false, 5L, "عرصه بازی های اولیه در ایران ", 3L, "دسته بازی PS4", 3800m },
                    { 8L, false, 5L, "کنسول زیبا برای شما", 15L, "کنسول pes4", 790000m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "id",
                keyValue: 5L);
        }
    }
}
