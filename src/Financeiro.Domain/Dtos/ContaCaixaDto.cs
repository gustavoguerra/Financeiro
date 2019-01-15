namespace Financeiro.Domain.Dtos
{
    public class ContaCaixaDto
    {
        public int ID { get; set; } 

        public string DESCRICAO { get; set; }

        public int PARENTID { get; set; }

        public string CODCONTROLE { get; set; }
    }
}