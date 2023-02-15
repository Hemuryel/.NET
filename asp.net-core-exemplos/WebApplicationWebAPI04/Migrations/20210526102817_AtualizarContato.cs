using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationWebAPI04.Migrations
{
    public partial class AtualizarContato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Contatos (Nome, Email, Telefone) VALUES ('Fulano01', 'fulano01@gmail.com', '4199998888')");
            migrationBuilder.Sql("INSERT INTO Contatos (Nome, Email, Telefone) VALUES ('Fulano02', 'fulano02@gmail.com', '4299998888')");
            migrationBuilder.Sql("INSERT INTO Contatos (Nome, Email, Telefone) VALUES ('Fulano03', 'fulano03@gmail.com', '4399998888')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Contatos");
        }
    }
}
