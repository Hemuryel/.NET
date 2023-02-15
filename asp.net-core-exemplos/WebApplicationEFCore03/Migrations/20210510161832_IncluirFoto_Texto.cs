using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationEFCore03.Migrations
{
    public partial class IncluirFoto_Texto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "AlunosEF",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Texto",
                table: "AlunosEF",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "AlunosEF");

            migrationBuilder.DropColumn(
                name: "Texto",
                table: "AlunosEF");
        }
    }
}
