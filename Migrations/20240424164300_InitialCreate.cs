using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValorOil.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Operators",
                columns: table => new
                {
                    OperatorID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Operator_FirstName = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Operator_LastName = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operators", x => x.OperatorID);
                });

            migrationBuilder.CreateTable(
                name: "Wells",
                columns: table => new
                {
                    WellID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Well_Name = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Storage_Capacity = table.Column<decimal>(type: "TEXT", nullable: false),
                    Flow_Rate = table.Column<decimal>(type: "TEXT", nullable: false),
                    OperatorID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wells", x => x.WellID);
                    table.ForeignKey(
                        name: "FK_Wells_Operators_OperatorID",
                        column: x => x.OperatorID,
                        principalTable: "Operators",
                        principalColumn: "OperatorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    ReportID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReportParagraph = table.Column<string>(type: "TEXT", nullable: false),
                    WellID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.ReportID);
                    table.ForeignKey(
                        name: "FK_Reports_Wells_WellID",
                        column: x => x.WellID,
                        principalTable: "Wells",
                        principalColumn: "WellID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_WellID",
                table: "Reports",
                column: "WellID");

            migrationBuilder.CreateIndex(
                name: "IX_Wells_OperatorID",
                table: "Wells",
                column: "OperatorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Wells");

            migrationBuilder.DropTable(
                name: "Operators");
        }
    }
}
