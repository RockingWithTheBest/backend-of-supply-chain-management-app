using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace xx1.Migrations
{
    /// <inheritdoc />
    public partial class Data_For_Employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "Password", "RoleId" },
                values: new object[,]
                {
                    { 1, new DateOnly(2024, 11, 10), "maxmillian@gmail.com", "Max", "Millian", "PassNo1@", 8678576 },
                    { 2, new DateOnly(2024, 11, 10), "string", "string", "string", "string", 8678576 },
                    { 3, new DateOnly(1, 1, 1), "SZCDS@gmaolc.cps", "aefr", "aedawe", "Passwo1!", 8678576 },
                    { 4, new DateOnly(1, 1, 1), "weafsa@gmail.coesm", "aesf", "waedfaw", "Passwo1!", 8678576 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
