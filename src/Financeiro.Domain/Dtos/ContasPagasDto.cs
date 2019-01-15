using System.Collections.Generic;
using Financeiro.Domain.Cadastro;

namespace Financeiro.Domain.Dtos
{
    public class ContasPagasDto
    {
        public int ID { get; set; }
        public string DESCRICAO { get; private set; }
        public int EMPRESAID { get; private set; }
        public int FORNECEDORID { get; private set; }
        public int CONTABANCARIAID { get; set; }
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
    }
}