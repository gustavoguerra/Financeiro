using Financeiro.Domain.Cadastro;

namespace Financeiro.Domain.Dtos
{
    public class ContaBancariaDto
    {
        public int ID { get; set; } 

        public int EMPRESAID { get; set; }

        public string DESCRICAO { get; set; }

        public string CODBANCO { get; set; }

        public string AGENCIA { get; set; }

        public string CONTA { get; set; }

        public string GERENTE { get; set; }

        public string TELEFONE { get; set; }

        public string DATAABERTURA { get; set; }
    }
}