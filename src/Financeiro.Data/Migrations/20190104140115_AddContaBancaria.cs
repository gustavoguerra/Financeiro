using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Financeiro.Data.Migrations
{
    public partial class AddContaBancaria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContaBancaria",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EMPRESAID = table.Column<int>(nullable: true),
                    DESCRICAO = table.Column<string>(nullable: true),
                    CODIGOBANCO = table.Column<string>(nullable: true),
                    AGENCIA = table.Column<string>(nullable: true),
                    CONTA = table.Column<string>(nullable: true),
                    GERENTE = table.Column<string>(nullable: true),
                    TELEFONE = table.Column<string>(nullable: true),
                    DATAABERTURA = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaBancaria", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ContaBancaria_Empresa_EMPRESAID",
                        column: x => x.EMPRESAID,
                        principalTable: "Empresa",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContaBancaria_EMPRESAID",
                table: "ContaBancaria",
                column: "EMPRESAID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContaBancaria");
        }
    }
}
