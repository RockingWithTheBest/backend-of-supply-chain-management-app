using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace xx1.Migrations
{
    /// <inheritdoc />
    public partial class Data_For_Customer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "Password", "ReturnId", "RoleId", "ShippingAddress" },
                values: new object[,]
                {
                    { 1, new DateOnly(1, 1, 1), "", "John", "Doe", "Passwo1!", null, 37546743, "123 Elm St" },
                    { 2, new DateOnly(1, 1, 1), "", "Jane", "Smith", "", null, 37546743, "456 Oak St" },
                    { 3, new DateOnly(1, 1, 1), "", "Alice", "Johnson", "", null, 37546743, "789 Pine St" },
                    { 4, new DateOnly(1, 1, 1), "", "Bob", "Brown", "", null, 37546743, "321 Maple St" },
                    { 5, new DateOnly(1, 1, 1), "", "Charlie", "Davis", "", null, 37546743, "654 Cedar St" },
                    { 6, new DateOnly(1, 1, 1), "", "Eve", "Wilson", "", null, 37546743, "987 Birch St" },
                    { 7, new DateOnly(2004, 10, 30), "srjvhb", "sdfvderg", "efgfgs", "sdfvhndsr", null, 37546743, "hvxdbv" },
                    { 8, new DateOnly(1, 1, 1), "aesrfaewf@gmail.com", "esrferfefrewrfwef", "earfaefrewa", "Passwo1!", null, 37546743, "MOGUILIEV" },
                    { 9, new DateOnly(1, 1, 1), "aesrfaewf@gmail.com", "esrferfefrewrfwef", "earfaefrewa", "Passwo1!", null, 37546743, "MOGUILIEV" },
                    { 10, new DateOnly(1, 1, 1), "aesrfaewf@gmail.com", "esrferfefrewrfwef", "earfaefrewa", "Passwo1!", null, 37546743, "MOGUILIEV" },
                    { 11, new DateOnly(1, 1, 1), "aesrfaewf@gmail.com", "esrferfefrewrfwef", "earfaefrewa", "Passwo1!", null, 37546743, "MOGUILIEV" },
                    { 12, new DateOnly(1, 1, 1), "aesrfaewf@gmail.com", "esrferfefrewrfwef", "earfaefrewa", "Passwo1!", null, 37546743, "MOGUILIEV" },
                    { 13, new DateOnly(1, 1, 1), "aesrfaewf@gmail.com", "esrferfefrewrfwef", "earfaefrewa", "Passwo1!", null, 37546743, "MOGUILIEV" },
                    { 17, new DateOnly(1, 1, 1), "chandabrian@gmail.com", "Chanda", "Brian", "Passwo1!", null, 37546743, "New Orlean HouseNo3" },
                    { 18, new DateOnly(1, 1, 1), "lindah@gmail.com", "Lindah", "Chingeleshi", "Passwo1!", null, 37546743, "szdehvfbszjf" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18);
        }
    }
}
