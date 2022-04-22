using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoicesChecker.Migrations
{
    public partial class Naming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalToPayAfterDiscount",
                table: "Invoices",
                newName: "TotalAmount");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "Invoices",
                newName: "TotalToPayAfterDiscount");
        }
    }
}
