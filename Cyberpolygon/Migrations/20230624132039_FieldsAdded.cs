using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cyberpolygon.Migrations
{
    public partial class FieldsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OS",
                table: "Configuration",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "cobian",
                table: "Configuration",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ftp",
                table: "Configuration",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "postgresql",
                table: "Configuration",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "powershell",
                table: "Configuration",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "prox",
                table: "Configuration",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "veeam",
                table: "Configuration",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "zip",
                table: "Configuration",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OS",
                table: "Configuration");

            migrationBuilder.DropColumn(
                name: "cobian",
                table: "Configuration");

            migrationBuilder.DropColumn(
                name: "ftp",
                table: "Configuration");

            migrationBuilder.DropColumn(
                name: "postgresql",
                table: "Configuration");

            migrationBuilder.DropColumn(
                name: "powershell",
                table: "Configuration");

            migrationBuilder.DropColumn(
                name: "prox",
                table: "Configuration");

            migrationBuilder.DropColumn(
                name: "veeam",
                table: "Configuration");

            migrationBuilder.DropColumn(
                name: "zip",
                table: "Configuration");
        }
    }
}
