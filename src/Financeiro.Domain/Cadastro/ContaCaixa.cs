namespace Financeiro.Domain.Cadastro
{
    public class ContaCaixa : Entity
    {
        public string DESCRICAO { get; private set; }

        public int PARENTID  { get; private set; }

        public string CODCONTROLE { get; private set; }

        public ContaCaixa (string descricao, int parentid, string codcontrole)
        {
            CheckPropryt(descricao, parentid,codcontrole);

            SetPropryt(descricao, parentid, codcontrole);
        }

        public ContaCaixa()
        {
            
        }

        public void Update(string descricao, int parentid, string codcontrole)
        {
            CheckPropryt(descricao, parentid,codcontrole);

            SetPropryt(descricao, parentid, codcontrole);
        }

        private void SetPropryt(string descricao, int parentid, string codcontrole)
        {
            DESCRICAO = descricao;
            PARENTID = parentid;
            CODCONTROLE = codcontrole;
        }

        private void CheckPropryt(string descricao, int parentid, string codcontrole)
        {
            DomainException.When(string.IsNullOrEmpty(descricao), "Descrição Obrigatorio");
            DomainException.When(parentid < 0, "Codigo Incorreto");
            DomainException.When(string.IsNullOrEmpty(codcontrole), "Codigo Obrigatorio");
        }

 
    }
}