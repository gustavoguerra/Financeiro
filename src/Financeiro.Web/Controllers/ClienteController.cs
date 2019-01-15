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
    public class ClienteController : Controller
    {
        private readonly ClienteStorer _clientestore;

        private readonly IRepository<Cliente> _clienterepository;

        public ClienteController(ClienteStorer clientestore, IRepository<Cliente> clienterepository)
        {
            _clientestore = clientestore;
            _clienterepository = clienterepository;
        }
         [HttpPost]
        public IActionResult CreateOrEdit(ClienteViewModel model)
        {
            ClienteDto dto = new ClienteDto();

            SetPropriy(model, dto);

            _clientestore.Store(dto);

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var fornecedor = _clienterepository.GetAll();

            var viewmodel = fornecedor.Select(c => new ClienteViewModel
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
            var f = _clienterepository.GetById(ID);

            if (f is null)
                return View();
            else
            {
                var viewmodel = new ClienteViewModel
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
        private static void SetPropriy(ClienteViewModel model, ClienteDto dto)
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