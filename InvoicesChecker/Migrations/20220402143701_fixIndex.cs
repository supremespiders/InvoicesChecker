using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoicesChecker.Migrations
{
    public partial class fixIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FACTUUR_FACTUURNUMMER",
                table: "FACTUUR");

            migrationBuilder.AlterColumn<string>(
                name: "ORDERNR_AFNEMER",
                table: "FACTUUR",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FACTUURNUMMER",
                table: "FACTUUR",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FACTUUR_ORDERNR_AFNEMER",
                table: "FACTUUR",
                column: "ORDERNR_AFNEMER",
                unique: true,
                filter: "[ORDERNR_AFNEMER] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FACTUUR_ORDERNR_AFNEMER",
                table: "FACTUUR");

            migrationBuilder.AlterColumn<string>(
                name: "ORDERNR_AFNEMER",
                table: "FACTUUR",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FACTUURNUMMER",
                table: "FACTUUR",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FACTUUR_FACTUURNUMMER",
                table: "FACTUUR",
                column: "FACTUURNUMMER",
                unique: true,
                filter: "[FACTUURNUMMER] IS NOT NULL");
        }
    }
}
