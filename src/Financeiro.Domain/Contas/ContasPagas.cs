using Financeiro.Domain.Cadastro;

namespace Financeiro.Domain.Contas
{
    public class ContasPagas : Entity
    {
        public string DESCRICAO { get; private set; }
        public Empresa EMPRESA { get; private set; }
        public Fornecedor FORNECEDOR { get; private set; }
        public ContaBancaria CONTABANCARIA { get; set; }
        public string TIPOPAGAMENTO { get; set; }
        public string FAVORECIDO { get; set; }
        public string DOCUMENTO { get; private set; }
        public string STATUSPAGAMENTO { get; private set; }   
        public double VALOR { get; private set; }
        public string DATACONTA { get; private set; }
        public string PREVPAGAMENTO { get; private set; }
        public string DATAPAGAMENTO { get; private set; }
        public string OBSERVACAO { get; set; }
        public string DATATIME { get; private set; }

        public ContasPagas()
        {
            
        }

        public ContasPagas (string descricao, Empresa empresa, Fornecedor fornecedor,ContaBancaria contabancaria,string tipopagamento,string favorecido, string documento,string statuspagamento, double valor, string dataconta, string datapagamento, string prevpagamento, string observacao, string datatime)
        {
            CheckPropried(descricao,empresa,fornecedor,contabancaria,tipopagamento,favorecido,documento,statuspagamento,valor,dataconta,datapagamento,prevpagamento,observacao,datatime);

            SetPropried(descricao,empresa,fornecedor,contabancaria,tipopagamento,favorecido,documento,statuspagamento,valor,dataconta,datapagamento,prevpagamento,observacao,datatime);
        }

        public void Update(string descricao, Empresa empresa, Fornecedor fornecedor,ContaBancaria contabancaria,string tipopagamento,string favorecido, string documento,string statuspagamento, double valor, string dataconta, string datapagamento, string prevpagamento, string observacao, string datatime)
        {
            CheckPropried(descricao,empresa,fornecedor,contabancaria,tipopagamento,favorecido,documento,statuspagamento,valor,dataconta,datapagamento,prevpagamento,observacao,datatime);

            SetPropried(descricao,empresa,fornecedor,contabancaria,tipopagamento,favorecido,documento,statuspagamento,valor,dataconta,datapagamento,prevpagamento,observacao,datatime);
        }

        private void SetPropried(string descricao, Empresa empresa, Fornecedor fornecedor,ContaBancaria contabancaria,string tipopagamento,string favorecido, string documento,string statuspagamento, double valor, string dataconta, string datapagamento, string prevpagamento, string observacao, string datatime)
        {
            DESCRICAO = descricao;
            EMPRESA = empresa;
            FORNECEDOR = fornecedor;
            CONTABANCARIA = contabancaria;
            TIPOPAGAMENTO = TIPOPAGAMENTO;
            FAVORECIDO = favorecido;
            DOCUMENTO = documento;
            STATUSPAGAMENTO = statuspagamento;
            VALOR = valor;
            DATACONTA = dataconta;
            PREVPAGAMENTO = prevpagamento;
            DATAPAGAMENTO = datapagamento;
            OBSERVACAO = observacao;
            DATATIME = DATATIME;
        }

        private static void CheckPropried(string descricao, Empresa empresa, Fornecedor fornecedor,ContaBancaria contabancaria,string tipopagamento,string favorecido, string documento,string statuspagamento, double valor, string dataconta, string datapagamento, string prevpagamento, string observacao, string datatime)
        {
            DomainException.When(string.IsNullOrEmpty(descricao), "Descrição Obrigatorio");
            DomainException.When(empresa == null, "Empresa Obrigatorio");
            DomainException.When(fornecedor == null, "Fornecedor Obrigatorio");
            DomainException.When(contabancaria == null, "Conta Bancaria Obrigatorio");
            DomainException.When(string.IsNullOrEmpty(tipopagamento),"Tipo de Pagamento Obrigatorio");
            DomainException.When(string.IsNullOrEmpty(favorecido),"Favorecido Obrigatorio");
            DomainException.When(string.IsNullOrEmpty(documento), "Documento Obrigatorio");
            DomainException.When(string.IsNullOrEmpty(statuspagamento), "Estatos Pagamento Obrigatorio");
            DomainException.When(valor <= 0, "Valor deve ser maio que 0");
            DomainException.When(string.IsNullOrEmpty(dataconta), "Data da Conta Obrigatorio");
            DomainException.When(string.IsNullOrEmpty(documento), "Documento Obrigatorio");
            DomainException.When(string.IsNullOrEmpty(datatime), "Data Obrigatorio");
        }
    }
}