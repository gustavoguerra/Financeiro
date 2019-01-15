using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Financeiro.Web.Models;
using Financeiro.Domain.Account;

namespace Financeiro.Web.Controllers
{
    public class AccountController : Controller
    {

        private readonly IAuthentication _iauthentication;

        public AccountController(IAuthentication authentication)
        {
             _iauthentication = authentication;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var result = await _iauthentication.Authenticate(model.EMAIL,model.PASSWORD);
            if(result)
            {
                return  RedirectToAction("Index", "Dashboard");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Login Invalido.");
                return View(model);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await _iauthentication.Logout();

            return RedirectToAction("Index","Home");
        }
    }
}
