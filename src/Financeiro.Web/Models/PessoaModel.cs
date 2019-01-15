using System.ComponentModel.DataAnnotations;

namespace Financeiro.Web.Models
{
    public class PessoaModel
    {
        public int ID { get;  set; }     

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [StringLength(100, ErrorMessage = "Deve conter mais de 4 Caracteres", MinimumLength = 4)]
        [Display(Name = "Razão Spcial")]
        public string RAZAOSOCIAL { get;   set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Nome Fantasia")]
        public string NOMEFANTASIA { get;  set; }
        
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [StringLength(100, ErrorMessage = "CNPJ Invalido", MinimumLength = 19)]
        [Display(Name = "CNPJ")]
        public string CPFCNPJ { get;   set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [EmailAddress(ErrorMessage ="Email Invalido")]
        [Display(Name = "Email")]
        public string EMAIL { get;   set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Telefone")]
        public string TELEFONE { get; set; }      
          
        [Display(Name = "Celular")]
        public string CELULAR { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "CEP")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Endereço")]
        public string ENDERECO { get;  set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Numero")]
        public string NUMERO { get;   set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Bairro")]
        public string BAIRRO { get;  set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Cidade")]
        public string CIDADE { get;  set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Estado")]
        public string ESTADO { get;  set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Pais")]
        public string PAIS { get;   set; }
    }
}