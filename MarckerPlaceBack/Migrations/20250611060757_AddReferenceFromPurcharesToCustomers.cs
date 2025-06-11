using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarckerPlaceBack.Migrations
{
    /// <inheritdoc />
    public partial class AddReferenceFromPurcharesToCustomers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CustomerId",
                table: "Purchares",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Vegetables" },
                    { 2, "Toys" },
                    { 3, "cloth" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "BirthDay", "LastName", "MiddleName", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(1997, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dou", null, "John" },
                    { 2L, new DateTime(2004, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smit", "Ben", "Jim" },
                    { 3L, new DateTime(2005, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smit", null, "Debra" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Articul", "CategoryId", "Name", "Price" },
                values: new object[,]
                {
                    { 1L, "00000000-0000-0000-0000-000000000000", 1, "Cucumber", 0.85m },
                    { 2L, "00000000-0000-0000-0000-000000000000", 1, "Tomato", 1.10m },
                    { 3L, "00000000-0000-0000-0000-000000000000", 2, "Hot Wheels Car", 2.99m },
                    { 4L, "00000000-0000-0000-0000-000000000000", 3, "T-Shirt", 3.60m },
                    { 5L, "00000000-0000-0000-0000-000000000000", 3, "Pants", 12.50m }
                });

            migrationBuilder.InsertData(
                table: "Purchares",
                columns: new[] { "PurchareId", "CustomerId", "PurchareDate", "TotalPrice" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.80m },
                    { 2L, 2L, new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.50m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Purchares_CustomerId",
                table: "Purchares",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchares_Customers_CustomerId",
                table: "Purchares",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchares_Customers_CustomerId",
                table: "Purchares");

            migrationBuilder.DropIndex(
                name: "IX_Purchares_CustomerId",
                table: "Purchares");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Purchares",
                keyColumn: "PurchareId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Purchares",
                keyColumn: "PurchareId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2L);

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Purchares");
        }
    }
}
