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
                    Week = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceFiles", x => x.Id);
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
                    PRIJS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BTWSOORT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRIJSEENHEID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NETTOBEDRAG = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    ORDERNR_AFNEMER = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.CreateIndex(
                name: "IX_FACTUUR_FACTUURREGELSId",
                table: "FACTUUR",
                column: "FACTUURREGELSId");

            migrationBuilder.CreateIndex(
                name: "IX_FACTUUR_InvoiceFileId",
                table: "FACTUUR",
                column: "InvoiceFileId");

            migrationBuilder.CreateIndex(
                name: "IX_FACTUURREGEL_FACTUURREGELSId",
                table: "FACTUURREGEL",
                column: "FACTUURREGELSId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FACTUUR");

            migrationBuilder.DropTable(
                name: "FACTUURREGEL");

            migrationBuilder.DropTable(
                name: "InvoiceFiles");

            migrationBuilder.DropTable(
                name: "FACTUURREGELS");
        }
    }
}
