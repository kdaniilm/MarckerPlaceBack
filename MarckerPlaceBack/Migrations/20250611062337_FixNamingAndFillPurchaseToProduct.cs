using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarckerPlaceBack.Migrations
{
    /// <inheritdoc />
    public partial class FixNamingAndFillPurchaseToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchaseId",
                table: "PurchasesToProducts");

            migrationBuilder.UpdateData(
                table: "Purchares",
                keyColumn: "PurchareId",
                keyValue: 1L,
                column: "PurchareDate",
                value: new DateTime(2025, 6, 4, 12, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Purchares",
                keyColumn: "PurchareId",
                keyValue: 2L,
                column: "PurchareDate",
                value: new DateTime(2025, 6, 6, 11, 25, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Purchares",
                columns: new[] { "PurchareId", "CustomerId", "PurchareDate", "TotalPrice" },
                values: new object[,]
                {
                    { 3L, 2L, new DateTime(2025, 6, 6, 12, 10, 0, 0, DateTimeKind.Unspecified), 18.2m },
                    { 4L, 3L, new DateTime(2025, 6, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), 14m },
                    { 5L, 1L, new DateTime(2025, 6, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), 2.99m }
                });

            migrationBuilder.InsertData(
                table: "PurchasesToProducts",
                columns: new[] { "PurchaseToProductId", "ProductId", "ProductsCount", "PurchareId" },
                values: new object[,]
                {
                    { 1L, 1L, 2, 1L },
                    { 2L, 2L, 1, 1L },
                    { 3L, 5L, 1, 2L },
                    { 4L, 4L, 2, 3L },
                    { 5L, 2L, 10, 3L },
                    { 6L, 1L, 10, 4L },
                    { 7L, 2L, 5, 4L },
                    { 8L, 3L, 1, 5L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PurchasesToProducts",
                keyColumn: "PurchaseToProductId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "PurchasesToProducts",
                keyColumn: "PurchaseToProductId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "PurchasesToProducts",
                keyColumn: "PurchaseToProductId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "PurchasesToProducts",
                keyColumn: "PurchaseToProductId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "PurchasesToProducts",
                keyColumn: "PurchaseToProductId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "PurchasesToProducts",
                keyColumn: "PurchaseToProductId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "PurchasesToProducts",
                keyColumn: "PurchaseToProductId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "PurchasesToProducts",
                keyColumn: "PurchaseToProductId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Purchares",
                keyColumn: "PurchareId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Purchares",
                keyColumn: "PurchareId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Purchares",
                keyColumn: "PurchareId",
                keyValue: 5L);

            migrationBuilder.AddColumn<long>(
                name: "PurchaseId",
                table: "PurchasesToProducts",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Purchares",
                keyColumn: "PurchareId",
                keyValue: 1L,
                column: "PurchareDate",
                value: new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Purchares",
                keyColumn: "PurchareId",
                keyValue: 2L,
                column: "PurchareDate",
                value: new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
