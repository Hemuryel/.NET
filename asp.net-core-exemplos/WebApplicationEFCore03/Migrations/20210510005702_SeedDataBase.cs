using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationEFCore03.Migrations
{
    public partial class SeedDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO AlunosEF (nome, email, sexo, nascimento) VALUES('Fulano01', 'Masculino', 'fulano01@hotmail.com', '01/02/1990');");
            migrationBuilder.Sql("INSERT INTO AlunosEF (nome, email, sexo, nascimento) VALUES('Fulano02', 'Masculino', 'fulano02@hotmail.com', '02/02/1991');");
            migrationBuilder.Sql("INSERT INTO AlunosEF (nome, email, sexo, nascimento) VALUES('Fulano03', 'Masculino', 'fulano03@hotmail.com', '03/02/1992');");
            migrationBuilder.Sql("INSERT INTO AlunosEF (nome, email, sexo, nascimento) VALUES('Fulano04', 'Masculino', 'fulano04@hotmail.com', '04/02/1993');");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM AlunosEF");
        }
    }
}
