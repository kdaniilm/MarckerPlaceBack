using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarckerPlaceBack.Migrations
{
    /// <inheritdoc />
    public partial class FixNamingOfTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchasesToProducts_Products_ProductId",
                table: "PurchasesToProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchasesToProducts_Purchares_PurchareId",
                table: "PurchasesToProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchasesToProducts",
                table: "PurchasesToProducts");

            migrationBuilder.RenameTable(
                name: "PurchasesToProducts",
                newName: "PurcharesToProducts");

            migrationBuilder.RenameIndex(
                name: "IX_PurchasesToProducts_PurchareId",
                table: "PurcharesToProducts",
                newName: "IX_PurcharesToProducts_PurchareId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchasesToProducts_ProductId",
                table: "PurcharesToProducts",
                newName: "IX_PurcharesToProducts_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurcharesToProducts",
                table: "PurcharesToProducts",
                column: "PurchareToProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurcharesToProducts_Products_ProductId",
                table: "PurcharesToProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurcharesToProducts_Purchares_PurchareId",
                table: "PurcharesToProducts",
                column: "PurchareId",
                principalTable: "Purchares",
                principalColumn: "PurchareId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurcharesToProducts_Products_ProductId",
                table: "PurcharesToProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_PurcharesToProducts_Purchares_PurchareId",
                table: "PurcharesToProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurcharesToProducts",
                table: "PurcharesToProducts");

            migrationBuilder.RenameTable(
                name: "PurcharesToProducts",
                newName: "PurchasesToProducts");

            migrationBuilder.RenameIndex(
                name: "IX_PurcharesToProducts_PurchareId",
                table: "PurchasesToProducts",
                newName: "IX_PurchasesToProducts_PurchareId");

            migrationBuilder.RenameIndex(
                name: "IX_PurcharesToProducts_ProductId",
                table: "PurchasesToProducts",
                newName: "IX_PurchasesToProducts_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchasesToProducts",
                table: "PurchasesToProducts",
                column: "PurchareToProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasesToProducts_Products_ProductId",
                table: "PurchasesToProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasesToProducts_Purchares_PurchareId",
                table: "PurchasesToProducts",
                column: "PurchareId",
                principalTable: "Purchares",
                principalColumn: "PurchareId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
