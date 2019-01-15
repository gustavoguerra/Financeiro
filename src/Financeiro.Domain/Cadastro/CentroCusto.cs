namespace Financeiro.Domain.Cadastro
{
    public class CentroCusto : Entity
    {
        public string DESCRICAO { get; private set; }

        public string DATA { get; private set; }

        public CentroCusto()
        {
            
        }
        
        public CentroCusto(string descricao, string data)
        {
            DomainException.When(string.IsNullOrEmpty(descricao), "Descrição Obrigatorio");
            DomainException.When(string.IsNullOrEmpty(data), "Data Obrigatoria");

            DESCRICAO = descricao;
            DATA = data;
        }

        public void UPDATE(string descricao, string data)
        {
            DomainException.When(string.IsNullOrEmpty(descricao), "Descrição Obrigatoria");
            DomainException.When(string.IsNullOrEmpty(data), "Data Obrigatoria");

            DESCRICAO = descricao;
            DATA = data;
        }

    }
}