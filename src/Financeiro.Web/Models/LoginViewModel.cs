using System.ComponentModel.DataAnnotations;

namespace Financeiro.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Precisa informar Email")]
        public string EMAIL { get; set; }
        
        [Required(ErrorMessage = "Precisa informar senha")]
        public string PASSWORD { get; set; }
    }
}