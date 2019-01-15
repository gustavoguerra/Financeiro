using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Financeiro.Web.Models
{
    public class ContaBancariaViewModel
    {
        public int ID { get; set; } 
        
        [Required(ErrorMessage = "Obrigatorio selecionar uma Empresa")]
        public int EMPRESAID { get; set; }

        public string EMPRESANAME { get; set; }
        
        [Required(ErrorMessage = "Nome do banco obrigatorio")]
        [StringLength(100, ErrorMessage = "Nome Invalido", MinimumLength = 2)]
        public string DESCRICAO { get; set; }
        
        [Required(ErrorMessage = "Codigo do banco obrigatorio")]
        [StringLength(100, ErrorMessage = "Deve ter no minimo 3", MinimumLength = 3)]
        public string CODIGOBANCO { get; set; }
        
        [Required(ErrorMessage = "Agencia obrigatorio")]
        public string AGENCIA { get; set; }
        
        [Required(ErrorMessage = "Conta Bancaria Obrigatorio")]
        public string CONTA { get; set; }

        [Required(ErrorMessage = "Nome do gerente obrigatorio")]
        public string GERENTE { get; set; }

        [Required(ErrorMessage = "Telefone obrigatorio")]
        public string TELEFONE { get; set; }

        [Required(ErrorMessage = "Data abertura obrigatoria")]
        [DataType(DataType.Date)]
        public string DATAABERTURA { get; set; }

        public IEnumerable<EmpresaViewModel> EmpresaList { get; set; }
        
    }
}