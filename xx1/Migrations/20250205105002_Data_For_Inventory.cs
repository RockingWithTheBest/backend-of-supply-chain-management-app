using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace xx1.Migrations
{
    /// <inheritdoc />
    public partial class Data_For_Inventory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "CustomerId", "CustomerNames", "OrderCheckId", "OrderId", "PricePaid", "ProductName", "Quantity", "Status" },
                values: new object[,]
                {
                    { 7, 6, "Eve Wilson", 6, 1, 3599.96m, "Galaxy S23", 4, "Recieved Order" },
                    { 8, 3, "Alice Johnson", 10, 6, 119.96m, "Baseball Cap", 4, "New Order" },
                    { 9, 17, "Chanda Brian", 11, 22, 20000m, "Jordan 1 HighTop", 2, "Recieved Order" },
                    { 11, 17, "Eve Wilson", 16, 7, 2599.98m, "Dell XPS 13", 2, "New Order" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
