using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoicesChecker.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FACTUURREGELS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FACTUURREGELS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Week = table.Column<int>(type: "int", nullable: false),
                    RawXml = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceFiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Severity = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FACTUURREGEL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EAN_ARTIKELCODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GELEVERD_AANTAL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FACTUUR_AANTAL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRIJS = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BTWSOORT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRIJSEENHEID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NETTOBEDRAG = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ARTIKELCODE_LEVERANCIER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ARTIKELOMSCHRIJVING = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FACTUURREGELSId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FACTUURREGEL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FACTUURREGEL_FACTUURREGELS_FACTUURREGELSId",
                        column: x => x.FACTUURREGELSId,
                        principalTable: "FACTUURREGELS",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FACTUUR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GLN_PARTNER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GLN_ENVELOP_ZELF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TESTINDICATOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FACTUURSOORT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FACTUURNUMMER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FACTUURDATUM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ORDERNR_AFNEMER = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ORDER_DATUM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAKBONNUMMER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AFLEVERDATUM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FACTUURREFERENTIENR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GLN_KOPERADRES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GLN_AFLEVERADRES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GLN_LEVERANCIER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GLN_FACTUURADRES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BTW_REGISTRATIE_NR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VALUTA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FACTUURREGELSId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Payed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    InvoiceFileId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FACTUUR", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FACTUUR_FACTUURREGELS_FACTUURREGELSId",
                        column: x => x.FACTUURREGELSId,
                        principalTable: "FACTUURREGELS",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FACTUUR_InvoiceFiles_InvoiceFileId",
                        column: x => x.InvoiceFileId,
                        principalTable: "InvoiceFiles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Week = table.Column<int>(type: "int", nullable: false),
                    InvoiceAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountUsed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Order = table.Column<string>(type: "varchar(10)", nullable: true),
                    FactuurId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_FACTUUR_FactuurId",
                        column: x => x.FactuurId,
                        principalTable: "FACTUUR",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FACTUUR_CreatedAt",
                table: "FACTUUR",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_FACTUUR_FACTUURREGELSId",
                table: "FACTUUR",
                column: "FACTUURREGELSId");

            migrationBuilder.CreateIndex(
                name: "IX_FACTUUR_InvoiceFileId",
                table: "FACTUUR",
                column: "InvoiceFileId");

            migrationBuilder.CreateIndex(
                name: "IX_FACTUUR_ORDERNR_AFNEMER",
                table: "FACTUUR",
                column: "ORDERNR_AFNEMER",
                unique: true,
                filter: "[ORDERNR_AFNEMER] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FACTUURREGEL_FACTUURREGELSId",
                table: "FACTUURREGEL",
                column: "FACTUURREGELSId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_FactuurId",
                table: "Payments",
                column: "FactuurId",
                unique: true,
                filter: "[FactuurId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Order",
                table: "Payments",
                column: "Order",
                unique: true,
                filter: "[Order] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FACTUURREGEL");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "FACTUUR");

            migrationBuilder.DropTable(
                name: "FACTUURREGELS");

            migrationBuilder.DropTable(
                name: "InvoiceFiles");
        }
    }
}
