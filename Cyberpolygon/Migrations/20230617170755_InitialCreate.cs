using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cyberpolygon.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Configuration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutounattendPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VmTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoresNumber = table.Column<int>(type: "int", nullable: false),
                    RamNumber = table.Column<int>(type: "int", nullable: false),
                    DiskSizeNumber = table.Column<int>(type: "int", nullable: false),
                    IsoFilename = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuration", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuration");
        }
    }
}
