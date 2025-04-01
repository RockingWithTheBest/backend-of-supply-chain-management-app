using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace xx1.Migrations
{
    /// <inheritdoc />
    public partial class Data_For_OrderCheck : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OrderChecks",
                columns: new[] { "Id", "OrderId", "ProductId", "ProductName", "ProductQuantity", "Status" },
                values: new object[,]
                {
                    { 6, 1, 2, "Galaxy S23", 5, "Order Supplied" },
                    { 10, 6, 19, "Baseball Cap", 4, "Order Supplied" },
                    { 11, 22, 36, "Jordan 1 HighTop", 2, "Order Supplied" },
                    { 12, 6, 19, "Baseball Cap", 2, "Order Supplied" },
                    { 13, 4, 15, "Skinny Jeans", 1, "Order Supplied" },
                    { 14, 4, 15, "Skinny Jeans", 2, "Order Supplied" },
                    { 15, 6, 19, "Baseball Cap", 1, "Order Supplied" },
                    { 16, 7, 4, "Dell XPS 13", 1, "Order Supplied" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderChecks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderChecks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderChecks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderChecks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrderChecks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OrderChecks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OrderChecks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OrderChecks",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
