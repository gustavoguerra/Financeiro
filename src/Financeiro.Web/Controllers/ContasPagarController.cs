using System.Linq;
using Financeiro.Domain;
using Financeiro.Domain.Cadastro;
using Financeiro.Domain.Contas;
using Financeiro.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Web.Controllers
{
     [Authorize]
    public class ContasPagarController : Controller
    {
        private readonly IRepository<ContasPagas> _contaspagarrepository;
        private readonly IRepository<Fornecedor> _fornecedorrepository;
        private readonly IRepository<Empresa> _empresarepository;
        private readonly IRepository<CentroCusto> _centrocustorepository;
        private readonly IRepository<ContaCaixa> _contacaixarepository;

        public ContasPagarController(IRepository<ContasPagas> contaspagarrepository, IRepository<Fornecedor> fornecedorrepositry, 
            IRepository<Empresa> empresarepository, IRepository<CentroCusto> centrocustorepository, IRepository<ContaCaixa> contacaixarepository)
        {
            _contaspagarrepository = contaspagarrepository;
            _fornecedorrepository = fornecedorrepositry;
            _empresarepository = empresarepository;
            _centrocustorepository = centrocustorepository;
            _contacaixarepository = contacaixarepository;
        }        

        public IActionResult Criar()
        {
            var viewmodel = new ContasPagasViewModel();
            var empresa = _empresarepository.GetAll();
            var fornecedor = _fornecedorrepository.GetAll();
            var contacaixa =_contacaixarepository.GetAll();
            var centrocusto = _centrocustorepository.GetAll();

            viewmodel.ListFornecedor = fornecedor.Select(e => new FornecedorViewModel { ID = e.ID, NOMEFANTASIA = e.NOMEFANTASIA });
            viewmodel.ListEmpresa = empresa.Select(e => new EmpresaViewModel { ID = e.ID, NOMEFANTASIA = e.NOMEFANTASIA });
            viewmodel.ListCentroCusto = centrocusto.Select(e => new CentroCustoViewModel { ID = e.ID, DESCRICAO = e.DESCRICAO });
            viewmodel.ListContaCaixa = contacaixa.Select(e => new ContaCaixaViewModel { ID = e.ID, DESCRICAO = e.DESCRICAO });
            // fazer daqui
            return View(viewmodel);
        }

        [HttpPost]
        public IActionResult Criar(ContasPagasViewModel model)
        {
            return View();
        }








    }
}