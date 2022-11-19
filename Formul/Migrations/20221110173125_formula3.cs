using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Formul.Migrations
{
    public partial class formula3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Formul",
                table: "Formulas",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Formul",
                table: "Formulas");
        }
    }
}
