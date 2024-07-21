using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalculatorAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FinishingCeilings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lambda = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Thicness = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinishingCeilings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinishingExteriorWalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lambda = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Thicness = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinishingExteriorWalls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinishingFoundations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lambda = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Thicness = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinishingFoundations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinishingInteriorWalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lambda = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Thicness = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinishingInteriorWalls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinishingRoofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lambda = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Thicness = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinishingRoofs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InsulationCeiling",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lambda = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Thicness = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsulationCeiling", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InsulationFoundation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lambda = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Thicness = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsulationFoundation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InsulationWalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lambda = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Thicness = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsulationWalls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StructureCeiling",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lambda = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Thicness = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StructureCeiling", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StructureFoundation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lambda = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Thicness = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StructureFoundation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StructureRoof",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lambda = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Thicness = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StructureRoof", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StructureWalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lambda = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Thicness = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StructureWalls", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FinishingCeilings");

            migrationBuilder.DropTable(
                name: "FinishingExteriorWalls");

            migrationBuilder.DropTable(
                name: "FinishingFoundations");

            migrationBuilder.DropTable(
                name: "FinishingInteriorWalls");

            migrationBuilder.DropTable(
                name: "FinishingRoofs");

            migrationBuilder.DropTable(
                name: "InsulationCeiling");

            migrationBuilder.DropTable(
                name: "InsulationFoundation");

            migrationBuilder.DropTable(
                name: "InsulationWalls");

            migrationBuilder.DropTable(
                name: "StructureCeiling");

            migrationBuilder.DropTable(
                name: "StructureFoundation");

            migrationBuilder.DropTable(
                name: "StructureRoof");

            migrationBuilder.DropTable(
                name: "StructureWalls");
        }
    }
}
