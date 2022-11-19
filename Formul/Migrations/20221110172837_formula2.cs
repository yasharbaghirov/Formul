using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Formul.Migrations
{
    public partial class formula2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ParametrName",
                table: "Parametrs",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParametrName",
                table: "Parametrs");
        }
    }
}
