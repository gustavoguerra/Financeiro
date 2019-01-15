using Financeiro.Domain.Dtos;

namespace Financeiro.Domain.Cadastro
{
    public class FornecedorStorer
    {
        private readonly IRepository<Fornecedor> _fornecedorRepository;

        public FornecedorStorer(IRepository<Fornecedor> fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;     
        }

        public void Store(FornecedorDto dto)
        {
            var fornecedor = _fornecedorRepository.GetById(dto.ID);

            if(fornecedor == null)
            {
                fornecedor = new Fornecedor(dto.NOMEFANTASIA,dto.RAZAOSOCIAL,dto.CPFCNPJ,dto.EMAIL,dto.TELEFONE,dto.CELULAR,dto.CEP,dto.ENDERECO,dto.NUMERO,dto.BAIRRO,dto.CIDADE,dto.ESTADO,dto.PAIS);
                _fornecedorRepository.Save(fornecedor);
            }
            else
            {
                fornecedor.Update(dto.NOMEFANTASIA,dto.RAZAOSOCIAL,dto.CPFCNPJ,dto.EMAIL,dto.TELEFONE,dto.CELULAR,dto.CEP,dto.ENDERECO,dto.NUMERO,dto.BAIRRO,dto.CIDADE,dto.ESTADO,dto.PAIS);
                _fornecedorRepository.Save(fornecedor);
            }
        }
    }
} 