using System.Threading.Tasks;
using Financeiro.Domain.Account;
using Financeiro.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IManager _imanagar;

        public UserController(IManager manager)
        {
            _imanagar =manager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserViewModel model)
        {
            await _imanagar.CreateAsync(model.EMAIL,model.PASSWORD,model.ROLE);
            
            return View();
        }
    }
}