using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Financeiro.Data.Migrations
{
    public partial class AddFornecedo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NOMEFANTASIA = table.Column<string>(nullable: true),
                    RAZAOSOCIAL = table.Column<string>(nullable: true),
                    CPFCNPJ = table.Column<string>(nullable: true),
                    EMAIL = table.Column<string>(nullable: true),
                    TELEFONE = table.Column<string>(nullable: true),
                    CELULAR = table.Column<string>(nullable: true),
                    CEP = table.Column<string>(nullable: true),
                    ENDERECO = table.Column<string>(nullable: true),
                    NUMERO = table.Column<string>(nullable: true),
                    BAIRRO = table.Column<string>(nullable: true),
                    CIDADE = table.Column<string>(nullable: true),
                    ESTADO = table.Column<string>(nullable: true),
                    PAIS = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fornecedor");
        }
    }
}
