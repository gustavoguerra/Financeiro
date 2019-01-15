using System.ComponentModel.DataAnnotations;

namespace Financeiro.Web.Models
{
    public class CentroCustoViewModel
    {
        public int ID { get; set; }
        
        [Required(ErrorMessage = "É preciso colocar uma Descrição")]
        public string DESCRICAO { get; set; }

        public string DATA { get; set; }
    }
}