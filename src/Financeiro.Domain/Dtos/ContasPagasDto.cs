using System.Collections.Generic;
using Financeiro.Domain.Cadastro;

namespace Financeiro.Domain.Dtos
{
    public class ContasPagasDto
    {
        public int ID { get; set; }
        public string DESCRICAO { get;  set; }
        public int EMPRESAID { get;  set; }
        public int FORNECEDORID { get;  set; }
        public int CONTABANCARIAID { get; set; }
        public string TIPOPAGAMENTO { get; set; }
        public string FAVORECIDO { get; set; }
        public string DOCUMENTO { get;  set; }
        public string STATUSPAGAMENTO { get;  set; }   
        public double VALOR { get;  set; }
        public string DATACONTA { get;  set; }
        public string PREVPAGAMENTO { get;  set; }
        public string DATAPAGAMENTO { get;  set; }
        public string OBSERVACAO { get; set; }
        public string DATATIME { get;  set; }       
    }
}