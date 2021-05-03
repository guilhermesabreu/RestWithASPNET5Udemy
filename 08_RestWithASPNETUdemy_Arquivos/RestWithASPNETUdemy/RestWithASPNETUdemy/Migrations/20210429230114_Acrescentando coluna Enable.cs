using Microsoft.EntityFrameworkCore.Migrations;

namespace RestWithASPNETUdemy.Migrations
{
    public partial class AcrescentandocolunaEnable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "Persons",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "Persons");
        }
    }
}
