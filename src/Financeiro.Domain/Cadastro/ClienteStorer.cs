using Financeiro.Domain.Dtos;

namespace Financeiro.Domain.Cadastro
{
    public class ClienteStorer
    {
        private readonly IRepository<Cliente> _clienteRepository;

        public ClienteStorer(IRepository<Cliente> clienteRepository)
        {
            _clienteRepository = clienteRepository;     
        }

        public void Store(ClienteDto dto)
        {
            var cliente = _clienteRepository.GetById(dto.ID);

            if(cliente is null)
            {
                cliente = new Cliente(dto.NOMEFANTASIA,dto.RAZAOSOCIAL,dto.CPFCNPJ,dto.EMAIL,dto.TELEFONE,dto.CELULAR,dto.CEP,dto.ENDERECO,dto.NUMERO,dto.BAIRRO,dto.CIDADE,dto.ESTADO,dto.PAIS);
                _clienteRepository.Save(cliente);
            }
            else
            {
                cliente.Update(dto.NOMEFANTASIA,dto.RAZAOSOCIAL,dto.CPFCNPJ,dto.EMAIL,dto.TELEFONE,dto.CELULAR,dto.CEP,dto.ENDERECO,dto.NUMERO,dto.BAIRRO,dto.CIDADE,dto.ESTADO,dto.PAIS);
                _clienteRepository.Save(cliente);
            }

        }
    }
} 