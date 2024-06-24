using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuroraAuto.Migrations
{
    /// <inheritdoc />
    public partial class TablesUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryID1",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_CategoryID1",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CategoryID1",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "Product",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryID",
                table: "Product",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryID",
                table: "Product",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryID",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_CategoryID",
                table: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryID",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID1",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryID1",
                table: "Product",
                column: "CategoryID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryID1",
                table: "Product",
                column: "CategoryID1",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
