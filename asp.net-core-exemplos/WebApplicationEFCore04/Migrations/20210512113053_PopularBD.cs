using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationEFCore04.Migrations
{
    public partial class PopularBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO ClientesEF04 (nome, email) VALUES ('Fulano01', 'fulano01@gmail.com')");
            migrationBuilder.Sql("INSERT INTO ClientesEF04 (nome, email) VALUES ('Fulano02', 'fulano02@gmail.com')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Clientes");
        }
    }
}
