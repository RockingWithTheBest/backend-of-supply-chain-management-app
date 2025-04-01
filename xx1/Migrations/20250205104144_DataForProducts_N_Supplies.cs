using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace xx1.Migrations
{
    /// <inheritdoc />
    public partial class DataForProducts_N_Supplies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Supplies",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "nicolaiS100@gmail.com", "Nicolai" },
                    { 2, "bwalaya@gmail.com", "Bwalya" },
                    { 3, "kenny100@gmail.com", "Kenny" },
                    { 4, "benyyK@gmail.com", "benjamin_K" },
                    { 5, "LionelMbewe@gmail.com", "Lionel M" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "Price", "StockQuantity", "SupplierId" },
                values: new object[,]
                {
                    { 2, "Samsung", "Electronics", "Galaxy S23", 899.99m, 13, 3 },
                    { 3, "Apple", "Electronics", "MacBook Pro", 1999.99m, 20, 4 },
                    { 4, "Dell", "Electronics", "Dell XPS 13", 1299.99m, 14, 5 },
                    { 5, "Sony", "Electronics", "Sony WH-1000XM4", 349.99m, 100, 5 },
                    { 6, "LG", "Electronics", "4K Ultra HD TV", 799.99m, 25, 2 },
                    { 7, "Amazon", "Electronics", "Smart Home Hub", 149.99m, 80, 3 },
                    { 8, "Boosted", "Electronics", "Electric Skateboard", 1299.99m, 10, 4 },
                    { 9, "Rad Power Bikes", "Motors", "Electric Bike", 1499.99m, 25, 5 },
                    { 10, "Harley", "Motors", "Harley Davidson Motorcycle", 19999.99m, 23, 5 },
                    { 11, "Yamaha", "Motors", "Yamaha Outboard Motor", 3000m, 8, 3 },
                    { 12, "Garmin", "Motors", "Car GPS Navigation", 199.99m, 40, 2 },
                    { 13, "ChargePoint", "Motors", "Electric Car Charger", 499.99m, 20, 3 },
                    { 14, "Nike", "Clothes", "Graphic T-Shirt", 24.99m, 150, 4 },
                    { 15, "Levi’s", "Clothes", "Skinny Jeans", 59.99m, 77, 5 },
                    { 16, "Zara", "Clothes", "Leather Jacket", 129.99m, 30, 1 },
                    { 17, "Adidas", "Clothes", "Windbreaker", 49.99m, 60, 1 },
                    { 18, "Puma", "Clothes", "Sneakers", 89.99m, 70, 5 },
                    { 19, "New Era", "Clothes", "Baseball Cap", 29.99m, 93, 2 },
                    { 20, "H&M", "Clothes", "Formal Dress", 79.99m, 40, 2 },
                    { 21, "Columbia", "Clothes", "Winter Coat", 139.99m, 15, 2 },
                    { 23, "Samsung", "Electronics", "AirPods", 345.99m, 20, 2 },
                    { 35, "Apple", "Electronics", "iphone 14", 1234.98m, 4, 2 },
                    { 36, "Nike", "Clothes", "Jordan 1 HighTop", 10000m, 8, 2 },
                    { 37, "Nike", "Motors", "Jordan 9", 999.99m, 23, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Supplies",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
