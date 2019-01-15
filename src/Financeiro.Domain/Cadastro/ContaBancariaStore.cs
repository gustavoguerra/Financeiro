using Financeiro.Domain.Dtos;

namespace Financeiro.Domain.Cadastro
{
    public class ContaBancariaStore
    {
        private readonly IRepository<ContaBancaria> _contabancariarepository;
        private readonly IRepository<Empresa> _empresarepository;

        public ContaBancariaStore(IRepository<ContaBancaria> contabancariarepository, IRepository<Empresa> empresarepository)
        {
            _contabancariarepository = contabancariarepository;
            _empresarepository = empresarepository;
        }

        public void Store(ContaBancariaDto dto)
        {
            var empresa = _empresarepository.GetById(dto.EMPRESAID);

            DomainException.When(empresa == null,"Empresa Invalida");

            var contabancaria = _contabancariarepository.GetById(dto.ID);

            if (contabancaria is null)
            {
                contabancaria = new ContaBancaria(empresa,dto.DESCRICAO,dto.CODBANCO,dto.AGENCIA,dto.CONTA,dto.GERENTE,dto.TELEFONE,dto.DATAABERTURA);
                _contabancariarepository.Save(contabancaria);
            }
            else
            {
                contabancaria.Update(empresa,dto.DESCRICAO,dto.CODBANCO,dto.AGENCIA,dto.CONTA,dto.GERENTE,dto.TELEFONE,dto.DATAABERTURA);
                _contabancariarepository.Save(contabancaria);
            }
        }
    }
}