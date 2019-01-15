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
    public class EmpresaController : Controller
    {
         private readonly EmpresaStorer _empresastore;
        private readonly IRepository<Empresa> _empresarepository;

        public EmpresaController(EmpresaStorer empresastorer, IRepository<Empresa> empresarepository)
        {
            _empresastore = empresastorer;
            _empresarepository = empresarepository;
        }

        [HttpPost]
        public IActionResult CreateOrEdit(EmpresaViewModel model)
        {
            EmpresaDto dto = new EmpresaDto();

            SetPropriy(model, dto);

            _empresastore.Store(dto);

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var empresa = _empresarepository.GetAll();

            var viewmodel = empresa.Select(c => new EmpresaViewModel
            {
                ID = c.ID,
                RAZAOSOCIAL = c.RAZAOSOCIAL,
                NOMEFANTASIA = c.NOMEFANTASIA,
                CPFCNPJ = c.CPFCNPJ,
                TELEFONE = c.TELEFONE,
                EMAIL = c.EMAIL,
                ENDERECO = c.ENDERECO
            });

            return View(viewmodel);
        }
        public IActionResult CreateOrEdit(int ID)
        {
            var f = _empresarepository.GetById(ID);

            if (f is null)
                return View();
            else
            {
                var viewmodel = new EmpresaViewModel
                {
                    ID = f.ID,
                    NOMEFANTASIA = f.NOMEFANTASIA,
                    RAZAOSOCIAL = f.RAZAOSOCIAL,
                    CPFCNPJ = f.CPFCNPJ,
                    EMAIL = f.EMAIL,
                    TELEFONE = f.TELEFONE,
                    CELULAR = f.CELULAR,
                    CEP = f.CEP,
                    ENDERECO = f.ENDERECO,
                    NUMERO = f.NUMERO,
                    BAIRRO = f.BAIRRO,
                    CIDADE = f.CIDADE,
                    ESTADO = f.ESTADO,
                    PAIS = f.PAIS
                };
                return View(viewmodel);
            }            
        }
        private static void SetPropriy(EmpresaViewModel model, EmpresaDto dto)
        {
            dto.ID = model.ID;
            dto.NOMEFANTASIA = model.NOMEFANTASIA;
            dto.RAZAOSOCIAL = model.RAZAOSOCIAL;
            dto.CPFCNPJ = model.CPFCNPJ;
            dto.TELEFONE = model.TELEFONE;
            dto.CELULAR = model.CELULAR;
            dto.EMAIL = model.EMAIL;
            dto.CEP = model.CEP;
            dto.ENDERECO = model.ENDERECO;
            dto.NUMERO = model.NUMERO;
            dto.BAIRRO = model.BAIRRO;
            dto.CIDADE = model.CIDADE;
            dto.ESTADO = model.ESTADO;
            dto.PAIS = model.PAIS;
        }
    }
}