using Financeiro.Domain.Dtos;

namespace Financeiro.Domain.Cadastro
{
    public class EmpresaStorer
    {
        private readonly IRepository<Empresa> _empresaRepository;

        public EmpresaStorer(IRepository<Empresa> empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public void Store(EmpresaDto dto)
        {
            var empresa = _empresaRepository.GetById(dto.ID);

            if (empresa == null)
            {
                empresa = new Empresa(dto.NOMEFANTASIA, dto.RAZAOSOCIAL, dto.CPFCNPJ, dto.EMAIL, dto.TELEFONE, dto.CELULAR, dto.CEP, dto.ENDERECO, dto.NUMERO, dto.BAIRRO, dto.CIDADE, dto.ESTADO, dto.PAIS);
                _empresaRepository.Save(empresa);
            }
            else
            {
                empresa.Update(dto.NOMEFANTASIA, dto.RAZAOSOCIAL, dto.CPFCNPJ, dto.EMAIL, dto.TELEFONE, dto.CELULAR, dto.CEP, dto.ENDERECO, dto.NUMERO, dto.BAIRRO, dto.CIDADE, dto.ESTADO, dto.PAIS);
                _empresaRepository.Save(empresa);
            }
        }

    }
}