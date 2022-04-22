using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoicesChecker.Migrations
{
    public partial class AddedField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalToPayAfterDiscount",
                table: "Invoices",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "InvoiceFiles",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalToPayAfterDiscount",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "InvoiceFiles");
        }
    }
}
