using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace City.Migrations
{
    public partial class Withdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "homes");

            migrationBuilder.DropTable(
                name: "streets");

            migrationBuilder.CreateTable(
                name: "streets_new",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_streets_new", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "homes_new",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    id_streetID = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    year_repair = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_homes_new", x => x.ID);
                    table.ForeignKey(
                        name: "FK_homes_new_streets_new_id_streetID",
                        column: x => x.id_streetID,
                        principalTable: "streets_new",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_homes_new_id_streetID",
                table: "homes_new",
                column: "id_streetID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "homes_new");

            migrationBuilder.DropTable(
                name: "streets_new");

            migrationBuilder.CreateTable(
                name: "streets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_streets", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "homes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_streetID = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    year_repair = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_homes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_homes_streets_id_streetID",
                        column: x => x.id_streetID,
                        principalTable: "streets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_homes_id_streetID",
                table: "homes",
                column: "id_streetID");
        }
    }
}
