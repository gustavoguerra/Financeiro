using System.ComponentModel.DataAnnotations;

namespace Financeiro.Web.Models
{
    public class UserViewModel
    {
        public string ID { get; set; }
        
        [Required(ErrorMessage = "Email Obrigatorio")]
        public string EMAIL { get; set; }
        [Required(ErrorMessage = "Senha Obriatoria")]
        public string PASSWORD { get; set; }
        [Required]
        public string ROLE { get; set; }
    }
}