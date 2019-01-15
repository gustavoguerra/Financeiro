using Financeiro.Domain.Dtos;

namespace Financeiro.Domain.Cadastro
{
    public class ContaCaixaSotore
    {
        private readonly IRepository<ContaCaixa> _contacaixarestorepository;

        public ContaCaixaSotore(IRepository<ContaCaixa> contacaixastorerepository)
        {
            _contacaixarestorepository = contacaixastorerepository;
        }

        public void store(ContaCaixaDto dto)
        {
            var contacaixa = _contacaixarestorepository.GetById(dto.ID);

            if(contacaixa is null)
            {                
                contacaixa = new ContaCaixa(dto.DESCRICAO,dto.PARENTID,dto.CODCONTROLE);
                _contacaixarestorepository.Save(contacaixa);
            }
            else
            {
                contacaixa.Update(dto.DESCRICAO,dto.PARENTID,dto.CODCONTROLE);
                _contacaixarestorepository.Save(contacaixa);
            }
        }
    }
}