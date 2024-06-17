using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuroraAuto.Migrations
{
    /// <inheritdoc />
    public partial class tablesupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Customer_CustomerID",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Order_OrderID",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_CustomerID",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_OrderID",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "Payment");

            migrationBuilder.AddColumn<int>(
                name: "PaymentID",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Order_PaymentID",
                table: "Order",
                column: "PaymentID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Payment_PaymentID",
                table: "Order",
                column: "PaymentID",
                principalTable: "Payment",
                principalColumn: "PaymentID",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Payment_PaymentID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_PaymentID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "PaymentID",
                table: "Order");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "Payment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "Payment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CustomerID",
                table: "Payment",
                column: "CustomerID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payment_OrderID",
                table: "Payment",
                column: "OrderID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Customer_CustomerID",
                table: "Payment",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Order_OrderID",
                table: "Payment",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
