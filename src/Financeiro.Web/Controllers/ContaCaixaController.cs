using System.Collections.Generic;
using System.Linq;
using Financeiro.Domain;
using Financeiro.Domain.Cadastro;
using Financeiro.Domain.Dtos;
using Financeiro.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Web.Controllers
{
    public class ContaCaixaController : Controller
    {             

        private readonly IRepository<ContaCaixa> _contacaixarepositry;

        private readonly ContaCaixaSotore _contacaixastore;

        public ContaCaixaController(IRepository<ContaCaixa> contacaixarepository, ContaCaixaSotore contacaixastore)
        {
            _contacaixarepositry = contacaixarepository;
            _contacaixastore = contacaixastore;
        }

        public IActionResult Index()
        {
            var contacaixa = _contacaixarepositry.GetAll().OrderBy(a => a.CODCONTROLE);

            var viewmodel = contacaixa.Select(c => new ContaCaixaViewModel 
            {
                ID = c.ID,
                DESCRICAO = c.DESCRICAO,
                PARENTID = c.PARENTID,
                CODCONTROLE = c.CODCONTROLE
            });           
            
            return View(viewmodel);
        }    

        [HttpPost]
        public IActionResult CreatePai(string descri)
        {
            ModelState.Clear();
            
            var contacaixa = _contacaixarepositry.GetAll().Where(c => c.PARENTID == 0);
                        
            var qnt = contacaixa.Count();

            ContaCaixaDto dto = new ContaCaixaDto();    

            dto.DESCRICAO = descri;
            dto.PARENTID = 0;
            dto.CODCONTROLE = (qnt + 1).ToString();
            
            _contacaixastore.store(dto);

            //return RedirectToAction("Index", "ContaCaixa");
            return RedirectToAction("Index");            
        }

        [HttpPost]
        public JsonResult CreateFilho(string descri,int id_pai)
        {
            ModelState.Clear();

            var contacaixa = _contacaixarepositry.GetById(id_pai);

            int all = _contacaixarepositry.GetAll().Where(c => c.PARENTID == id_pai).Count();

            ContaCaixaDto dto = new ContaCaixaDto();

            dto.DESCRICAO = descri;
            dto.PARENTID = id_pai;
            dto.CODCONTROLE = contacaixa.CODCONTROLE + "." + (all + 1);

            _contacaixastore.store(dto);

            //return RedirectToAction("Index");
            return Json(dto);
        }
        public IActionResult AtualizarItem (string descri,int id_pai)
        {
            var contacaixa = _contacaixarepositry.GetById(id_pai);

            ContaCaixaDto dto = new ContaCaixaDto();

            dto.ID = id_pai;
            dto.DESCRICAO = descri;
            dto.CODCONTROLE = contacaixa.CODCONTROLE;            
            dto.PARENTID = contacaixa.PARENTID;

            _contacaixastore.store(dto);

            return RedirectToAction("Index");   
        }

    }
}