using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarckerPlaceBack.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePurchares : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Purchares_PurchareId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_PurchareId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PurchareId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "RegistationDate",
                table: "Customers",
                newName: "BirthDay");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Purchares",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthDay",
                table: "Customers",
                newName: "RegistationDate");

            migrationBuilder.AlterColumn<string>(
                name: "TotalPrice",
                table: "Purchares",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AddColumn<long>(
                name: "PurchareId",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_PurchareId",
                table: "Products",
                column: "PurchareId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Purchares_PurchareId",
                table: "Products",
                column: "PurchareId",
                principalTable: "Purchares",
                principalColumn: "PurchareId");
        }
    }
}
