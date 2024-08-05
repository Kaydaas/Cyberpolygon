using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cyberpolygon.Migrations
{
    public partial class AddBats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "folder",
                table: "Configuration",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "hotfix7",
                table: "Configuration",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "hotfix812",
                table: "Configuration",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "pass",
                table: "Configuration",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "port3389",
                table: "Configuration",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "port445",
                table: "Configuration",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "port80",
                table: "Configuration",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ports3389445",
                table: "Configuration",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ports3389445443",
                table: "Configuration",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ports804438080",
                table: "Configuration",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "zipmsi",
                table: "Configuration",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ziptest",
                table: "Configuration",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "folder",
                table: "Configuration");

            migrationBuilder.DropColumn(
                name: "hotfix7",
                table: "Configuration");

            migrationBuilder.DropColumn(
                name: "hotfix812",
                table: "Configuration");

            migrationBuilder.DropColumn(
                name: "pass",
                table: "Configuration");

            migrationBuilder.DropColumn(
                name: "port3389",
                table: "Configuration");

            migrationBuilder.DropColumn(
                name: "port445",
                table: "Configuration");

            migrationBuilder.DropColumn(
                name: "port80",
                table: "Configuration");

            migrationBuilder.DropColumn(
                name: "ports3389445",
                table: "Configuration");

            migrationBuilder.DropColumn(
                name: "ports3389445443",
                table: "Configuration");

            migrationBuilder.DropColumn(
                name: "ports804438080",
                table: "Configuration");

            migrationBuilder.DropColumn(
                name: "zipmsi",
                table: "Configuration");

            migrationBuilder.DropColumn(
                name: "ziptest",
                table: "Configuration");
        }
    }
}
