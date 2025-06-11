using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarckerPlaceBack.Migrations
{
    /// <inheritdoc />
    public partial class FixNaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PurchaseToProductId",
                table: "PurchasesToProducts",
                newName: "PurchareToProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PurchareToProductId",
                table: "PurchasesToProducts",
                newName: "PurchaseToProductId");
        }
    }
}
