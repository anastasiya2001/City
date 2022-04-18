using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace City.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Street",
                table: "Street");

            migrationBuilder.RenameTable(
                name: "Street",
                newName: "streets");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "streets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_streets",
                table: "streets",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_streets",
                table: "streets");

            migrationBuilder.RenameTable(
                name: "streets",
                newName: "Street");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Street",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Street",
                table: "Street",
                column: "ID");
        }
    }
}
