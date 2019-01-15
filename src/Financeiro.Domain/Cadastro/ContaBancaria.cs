namespace Financeiro.Domain.Cadastro
{
    public class ContaBancaria : Entity
    {

        public Empresa EMPRESA { get; private set; }

        public string DESCRICAO { get; private set; }

        public string CODIGOBANCO { get; private set; }

        public string AGENCIA { get; private set; }

        public string CONTA { get; private set; }

        public string GERENTE { get; private set; }

        public string TELEFONE { get; set; }

        public string DATAABERTURA { get; private set; }

        public ContaBancaria()
        {
            
        }

        public ContaBancaria(Empresa empresa, string descricao,string codigobanco, string agencia,string conta, string gerente,string telefone, string dataabertura)
        {
            CheckPropyt(empresa, descricao, codigobanco, agencia, conta, gerente, telefone, dataabertura);

            SetPropyt(empresa, descricao, codigobanco, agencia, conta, gerente, telefone, dataabertura);
        }

        public void Update(Empresa empresa, string descricao,string codigobanco, string agencia,string conta, string gerente,string telefone, string dataabertura)
        {
            CheckPropyt(empresa, descricao, codigobanco, agencia, conta, gerente, telefone, dataabertura);

            SetPropyt(empresa, descricao, codigobanco, agencia, conta, gerente, telefone, dataabertura);
        }

        private void SetPropyt(Empresa empresa, string descricao, string codigobanco, string agencia, string conta, string gerente, string telefone, string dataabertura)
        {
            EMPRESA = empresa;
            DESCRICAO = descricao;
            CODIGOBANCO = codigobanco;
            AGENCIA = agencia;
            CONTA = conta;
            GERENTE = gerente;
            TELEFONE = telefone;
            DATAABERTURA = dataabertura;
        }

        private static void CheckPropyt(Empresa empresa, string descricao, string codigobanco, string agencia, string conta, string gerente, string telefone, string dataabertura)
        {
            DomainException.When(empresa == null, "Empresa Obrigatorio");
            DomainException.When(string.IsNullOrEmpty(descricao), "Descrição Obrigatoria");
            DomainException.When(string.IsNullOrEmpty(codigobanco), "Codigo do Banco Obrigatorio");
            DomainException.When(string.IsNullOrEmpty(agencia), "Agenci Obrigatorioa");
            DomainException.When(string.IsNullOrEmpty(conta), "Conta Bancaria Obrigatorio");
            DomainException.When(string.IsNullOrEmpty(gerente), "Gerente Obrigatorio");
            DomainException.When(string.IsNullOrEmpty(telefone), "Telefone Obrigatorio");
            DomainException.When(string.IsNullOrEmpty(dataabertura), "Data de Abertura Obrigatorio");
        }
    }
}