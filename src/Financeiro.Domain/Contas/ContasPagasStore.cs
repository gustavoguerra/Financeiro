using Financeiro.Domain.Cadastro;
using Financeiro.Domain.Dtos;

namespace Financeiro.Domain.Contas
{
    public class ContasPagasStore
    {
        private readonly IRepository<Empresa> _empresarepository;

        private readonly IRepository<Fornecedor> _fornecedorrepository;

        private readonly IRepository<ContasPagas> _contapagarrepository;
        private readonly IRepository<ContaBancaria> _contabancariarepository;
        public ContasPagasStore(IRepository<Empresa> empresarepository, IRepository<Fornecedor> fornecedorrepository,IRepository<ContasPagas> contapagarrepotitory, IRepository<ContaBancaria> contabancariarepository)
        {
            _contapagarrepository = contapagarrepotitory;
            _empresarepository = empresarepository;
            _fornecedorrepository = fornecedorrepository;
            _contabancariarepository = contabancariarepository;
        }

        public void store(ContasPagasDto dto)
        {
            var empresa = _empresarepository.GetById(dto.EMPRESAID);
            var fornecedor = _fornecedorrepository.GetById(dto.FORNECEDORID);
            var contabancaria = _contabancariarepository.GetById(dto.CONTABANCARIAID);

            DomainException.When(empresa == null,"Precisa de Empresa");
            DomainException.When(fornecedor == null,"Precisa de Fornecedor");
            DomainException.When(contabancaria == null,"Precisa de Conta Bancaria");

            var contaspagar = _contapagarrepository.GetById(dto.ID);

            if(contaspagar is null)
            {
                contaspagar = new ContasPagas(dto.DESCRICAO,empresa,fornecedor,contabancaria,dto.TIPOPAGAMENTO,dto.FAVORECIDO, dto.DOCUMENTO,dto.STATUSPAGAMENTO,dto.VALOR,dto.DATACONTA,dto.DATAPAGAMENTO,dto.PREVPAGAMENTO,dto.OBSERVACAO,dto.DATATIME);
                _contapagarrepository.Save(contaspagar);
            }
            else
            {
                contaspagar.Update(dto.DESCRICAO,empresa,fornecedor,contabancaria,dto.TIPOPAGAMENTO,dto.FAVORECIDO, dto.DOCUMENTO,dto.STATUSPAGAMENTO,dto.VALOR,dto.DATACONTA,dto.DATAPAGAMENTO,dto.PREVPAGAMENTO,dto.OBSERVACAO,dto.DATATIME);
                _contapagarrepository.Save(contaspagar);
            }
        }
    }
}