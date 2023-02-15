using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationEFCore03.Migrations
{
    public partial class TipoSocio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoSocioId",
                table: "AlunosEF",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TipoSociosEF",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DuracaoEmMeses = table.Column<int>(type: "int", nullable: false),
                    TaxaDesconto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoSociosEF", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlunosEF_TipoSocioId",
                table: "AlunosEF",
                column: "TipoSocioId");

            migrationBuilder.AddForeignKey(
                name: "FK_AlunosEF_TipoSociosEF_TipoSocioId",
                table: "AlunosEF",
                column: "TipoSocioId",
                principalTable: "TipoSociosEF",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlunosEF_TipoSociosEF_TipoSocioId",
                table: "AlunosEF");

            migrationBuilder.DropTable(
                name: "TipoSociosEF");

            migrationBuilder.DropIndex(
                name: "IX_AlunosEF_TipoSocioId",
                table: "AlunosEF");

            migrationBuilder.DropColumn(
                name: "TipoSocioId",
                table: "AlunosEF");
        }
    }
}
