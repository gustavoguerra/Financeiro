using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Financeiro.Web.Models;
using Financeiro.Domain.Dtos;
using Financeiro.Domain.Cadastro;
using Financeiro.Domain;
using Microsoft.AspNetCore.Authorization;

namespace Financeiro.Web.Controllers
{
    [Authorize]
    public class CentroCustoController : Controller
    {
        private readonly IRepository<CentroCusto> _centrocustorepository;
        private readonly CentroCustoStore _centrocustostore;

        public CentroCustoController(IRepository<CentroCusto> centrocustorepository, CentroCustoStore centrocustostore)
        {
            _centrocustorepository = centrocustorepository;
            _centrocustostore = centrocustostore;
        }

        public IActionResult Index()
        {
            var centrocusto = _centrocustorepository.GetAll();

            var viewmodel = centrocusto.Select(c => new CentroCustoViewModel
            {
                ID = c.ID,
                DESCRICAO = c.DESCRICAO,
                DATA = c.DATA
            });

            return View(viewmodel);
        }

        [HttpGet]
        public IActionResult CreateOrEdit(int id)
        {
            var centrocusto = _centrocustorepository.GetById(id);

            if (centrocusto is null)
            {
                return View();
            }
            else
            {
                var viewmodel = new CentroCustoViewModel
                {
                    ID = centrocusto.ID,
                    DESCRICAO = centrocusto.DESCRICAO,
                    DATA = centrocusto.DATA
                };  
                return View(viewmodel);
            }
        }

        [HttpPost]
        public IActionResult CreateOrEdit(CentroCustoViewModel model)
        {
            CentroCustoDto dto = new CentroCustoDto();

            SetDto(model, dto);

            _centrocustostore.store(dto);
            return RedirectToAction("Index");
        }

        private static void SetDto(CentroCustoViewModel model, CentroCustoDto dto)
        {
            dto.ID = model.ID;
            dto.DESCRICAO = model.DESCRICAO;
            dto.DATA = System.DateTime.Now.ToString();
        }
    }
}