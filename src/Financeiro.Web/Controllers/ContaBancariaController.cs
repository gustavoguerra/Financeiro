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
    public class ContaBancariaController : Controller
    {
        private readonly IRepository<Empresa> _empresarepository;

        private readonly IRepository<ContaBancaria> _contabancariarepository;

        private readonly ContaBancariaStore _contabancariastore;

        public ContaBancariaController(IRepository<Empresa> empresarepository, IRepository<ContaBancaria> contabancariarepository, ContaBancariaStore contabancariastore)
        {
            _empresarepository = empresarepository;
            _contabancariarepository = contabancariarepository;
            _contabancariastore = contabancariastore;
        }

        [HttpPost]
        public IActionResult CreateOrEdit(ContaBancariaViewModel model)
        {
            ContaBancariaDto dto = new ContaBancariaDto();

            SetPropriy(model, dto);

            _contabancariastore.Store(dto);

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var contabancaria = _contabancariarepository.GetAll();            
            
            var viewmodel = contabancaria.Select(c => new ContaBancariaViewModel
            {
                ID = c.ID,
                EMPRESAID = c.EMPRESA.ID,
                EMPRESANAME = c.EMPRESA.NOMEFANTASIA,
                DESCRICAO = c.DESCRICAO,
                CODIGOBANCO = c.CODIGOBANCO,
                AGENCIA = c.AGENCIA,
                CONTA = c.CONTA,
                GERENTE = c.GERENTE,
                TELEFONE = c.TELEFONE,
                DATAABERTURA = c.DATAABERTURA
            });
            return View(viewmodel);
        }

        public IActionResult CreateOrEdit(int ID)
        {
            var viewmodel = new ContaBancariaViewModel();
            var empresa = _empresarepository.GetAll();

            viewmodel.EmpresaList = empresa.Select(e => new EmpresaViewModel { ID = e.ID, NOMEFANTASIA = e.NOMEFANTASIA });

            if (ID > 0) // Verifica se tem ID para Editar
            {
                var f = _contabancariarepository.GetById(ID);

                viewmodel.ID = f.ID;
                viewmodel.EMPRESAID = f.EMPRESA.ID;
                viewmodel.DESCRICAO = f.DESCRICAO;
                viewmodel.CODIGOBANCO = f.CODIGOBANCO;
                viewmodel.AGENCIA = f.AGENCIA;
                viewmodel.CONTA = f.CONTA;
                viewmodel.GERENTE = f.GERENTE;
                viewmodel.TELEFONE = f.TELEFONE;
                viewmodel.DATAABERTURA = f.DATAABERTURA;
            }
            return View(viewmodel);
        }
        private static void SetPropriy(ContaBancariaViewModel model, ContaBancariaDto dto)
        {
            dto.ID = model.ID;
            dto.EMPRESAID = model.EMPRESAID;
            dto.DESCRICAO = model.DESCRICAO;
            dto.CODBANCO = model.CODIGOBANCO;
            dto.CONTA = model.CONTA;
            dto.AGENCIA = model.AGENCIA;
            dto.GERENTE = model.GERENTE;
            dto.TELEFONE = model.TELEFONE;
            dto.DATAABERTURA = model.DATAABERTURA;
        }

    }
}