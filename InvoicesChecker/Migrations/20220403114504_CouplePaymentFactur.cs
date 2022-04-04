using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoicesChecker.Migrations
{
    public partial class CouplePaymentFactur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FactuurId",
                table: "Payments",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PRIJS",
                table: "FACTUURREGEL",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NETTOBEDRAG",
                table: "FACTUURREGEL",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Payed",
                table: "FACTUUR",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "FACTUUR",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_FactuurId",
                table: "Payments",
                column: "FactuurId",
                unique: true,
                filter: "[FactuurId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_FACTUUR_FactuurId",
                table: "Payments",
                column: "FactuurId",
                principalTable: "FACTUUR",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_FACTUUR_FactuurId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_FactuurId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "FactuurId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Payed",
                table: "FACTUUR");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "FACTUUR");

            migrationBuilder.AlterColumn<string>(
                name: "PRIJS",
                table: "FACTUURREGEL",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "NETTOBEDRAG",
                table: "FACTUURREGEL",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
