using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Financeiro.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Financeiro.Web.Controllers
{
     [Authorize]
    public class DashboardController : Controller
    {
       [Authorize]
        public IActionResult Index()
        {
            return View();
        }      
    }
}
