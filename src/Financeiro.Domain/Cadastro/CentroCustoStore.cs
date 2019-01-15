using Financeiro.Domain.Dtos;

namespace Financeiro.Domain.Cadastro
{
    public class CentroCustoStore
    {
        private readonly IRepository<CentroCusto> _centrodecustorepository;

        public CentroCustoStore(IRepository<CentroCusto> centrodecustrorepository)
        {
            _centrodecustorepository = centrodecustrorepository;
        }
        
        public void store(CentroCustoDto dto)
        {
            var centrocusto = _centrodecustorepository.GetById(dto.ID);

            if(centrocusto is null)
            {
                centrocusto = new CentroCusto(dto.DESCRICAO,dto.DATA);
                _centrodecustorepository.Save(centrocusto);            
            }
            else
            {
                centrocusto.UPDATE(dto.DESCRICAO,dto.DATA);
                _centrodecustorepository.Save(centrocusto);

            }        
        }
    }
}