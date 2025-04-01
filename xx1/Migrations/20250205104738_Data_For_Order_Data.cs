using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace xx1.Migrations
{
    /// <inheritdoc />
    public partial class Data_For_Order_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderStatus", "ProductId", "Quantity", "TaxStatus" },
                values: new object[,]
                {
                    { 1, 6, "Pending", 2, 4, "Taxed" },
                    { 2, 2, "Shipped", 3, 1, "Not Taxed" },
                    { 3, 1, "Delivered", 9, 3, "Taxed" },
                    { 4, 4, "Delivered", 15, 5, "Not Taxed" },
                    { 5, 3, "Delivered", 17, 1, "Taxed" },
                    { 6, 3, "Pending", 19, 4, "Not Taxed" },
                    { 7, 6, "Shipped", 4, 2, "Taxed" },
                    { 22, 17, "Pending", 36, 2, "Not Taxed" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22);
        }
    }
}
