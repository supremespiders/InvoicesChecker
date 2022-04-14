using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoicesChecker.Migrations
{
    public partial class InvoiceFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FACTUUR_InvoiceFiles_InvoiceFileId",
                table: "FACTUUR");

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceFileId",
                table: "FACTUUR",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FACTUUR_InvoiceFiles_InvoiceFileId",
                table: "FACTUUR",
                column: "InvoiceFileId",
                principalTable: "InvoiceFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FACTUUR_InvoiceFiles_InvoiceFileId",
                table: "FACTUUR");

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceFileId",
                table: "FACTUUR",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_FACTUUR_InvoiceFiles_InvoiceFileId",
                table: "FACTUUR",
                column: "InvoiceFileId",
                principalTable: "InvoiceFiles",
                principalColumn: "Id");
        }
    }
}
