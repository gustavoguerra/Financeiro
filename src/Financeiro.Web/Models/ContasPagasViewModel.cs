using System.Collections.Generic;
using Financeiro.Domain.Cadastro;

namespace Financeiro.Web.Models
{
    public class ContasPagasViewModel
    {
        public int ID { get; set; }
        public string DESCRICAO { get; set; }
        public int EMPRESAID { get; set; }
        public int FORNECEDORID { get; set; }
        public string DOCUMENTO { get; set; }
        public string STATUSPAGAMENTO { get; set; }   
        public double VALOR { get; set; }
        public string DATACONTA { get; set; }
        public string PREVPAGAMENTO { get; set; }
        public string DATAPAGAMENTO { get; set; }
        public string DATATIME { get; set; }   
        public List<int> CENTROCUSTOID { get; set; }
        public List<int> CONTACAIXAID { get; set; }
        public IEnumerable<EmpresaViewModel> ListEmpresa { get; set; }
        public IEnumerable<FornecedorViewModel> ListFornecedor { get; set; }
        public IEnumerable<CentroCustoViewModel> ListCentroCusto { get; set; }
        public IEnumerable<ContaCaixaViewModel> ListContaCaixa { get; set; }
    }
}