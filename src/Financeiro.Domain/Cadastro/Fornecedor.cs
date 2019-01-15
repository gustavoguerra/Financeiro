using System;

namespace Financeiro.Domain.Cadastro
{
    public class Fornecedor : Entity
    {
        public string NOMEFANTASIA { get; private set; }
        public string RAZAOSOCIAL { get;  private set; }
        public string CPFCNPJ { get;  private set; }
        public string EMAIL { get;  private set; }
        public string TELEFONE { get; private set; }
        public string CELULAR { get; private set; }
        public string CEP { get;   private set; }
        public string ENDERECO { get; private set; }
        public string NUMERO { get;  private set; }
        public string BAIRRO { get; private set; }
        public string CIDADE { get; private set; }
        public string ESTADO { get; private set; }
        public string PAIS { get;  private set; }   

        public Fornecedor(string NomeFantasia,string RazaoSocial, string CpfCnpj,string Email,string Telefone,string Celular, string Cep, string Endereco,string Numero, string Bairro, string Cidade, string Estado, string Pais)
        {
            CheckPropryt(NomeFantasia, RazaoSocial, CpfCnpj,Email,Telefone,Celular, Cep, Endereco, Numero, Bairro, Cidade, Estado, Pais);

            SetProprty(NomeFantasia, RazaoSocial, CpfCnpj,Email,Telefone,Celular, Cep, Endereco, Numero, Bairro, Cidade, Estado, Pais);
        }
        public void Update (string NomeFantasia,string RazaoSocial, string CpfCnpj,string Email,string Telefone,string Celular, string Cep, string Endereco,string Numero, string Bairro, string Cidade, string Estado, string Pais)
        {
            CheckPropryt(NomeFantasia, RazaoSocial, CpfCnpj,Email,Telefone,Celular, Cep, Endereco, Numero, Bairro, Cidade, Estado, Pais);

            SetProprty(NomeFantasia, RazaoSocial, CpfCnpj,Email,Telefone,Celular, Cep, Endereco, Numero, Bairro, Cidade, Estado, Pais);
        }

        public Fornecedor()
        {
            
        }
        private static void CheckPropryt(string NomeFantasia,string RazaoSocial, string CpfCnpj,string Email,string Telefone,string Celular, string Cep, string Endereco,string Numero, string Bairro, string Cidade, string Estado, string Pais)
        {
            DomainException.When(string.IsNullOrEmpty(NomeFantasia), "Nome Fantasia Obrigatorio");
            DomainException.When(string.IsNullOrEmpty(RazaoSocial), "Razão Social Obrigatorio");
            DomainException.When(string.IsNullOrEmpty(CpfCnpj), "CPF ou CNPJ Obrigatorio");
            DomainException.When(string.IsNullOrEmpty(Email), "Email Obrigatorio");
            DomainException.When(string.IsNullOrEmpty(Telefone), "Telefone Obrigaotrio");       
            DomainException.When(string.IsNullOrEmpty(Endereco), "Endereço Obrigatorio");
            DomainException.When(string.IsNullOrEmpty(Numero), "Numero Obrigatorio");
            DomainException.When(string.IsNullOrEmpty(Bairro), "Bairro Obrigatorio");
            DomainException.When(string.IsNullOrEmpty(Cidade), "Cidade Obrigatorio");
            DomainException.When(string.IsNullOrEmpty(Estado), "Estado Obrigatorio");
            DomainException.When(string.IsNullOrEmpty(Pais), "Pais Obrigatorio");            
            DomainException.When(string.IsNullOrEmpty(Cep), "CEP Obrigatorio");
            DomainException.When(Cep.Length < 4, "CEP Invalido");
        }
        private void SetProprty(string NomeFantasia,string RazaoSocial, string CpfCnpj,string Email,string Telefone,string Celular, string Cep, string Endereco,string Numero, string Bairro, string Cidade, string Estado, string Pais)
        {            
            NOMEFANTASIA = NomeFantasia;
            RAZAOSOCIAL = RazaoSocial;
            CPFCNPJ = CpfCnpj;
            EMAIL = Email;
            TELEFONE = Telefone;
            CELULAR = Celular;
            CEP = Cep;
            ENDERECO = Endereco;
            NUMERO = Numero;
            BAIRRO = Bairro;
            CIDADE = Cidade;
            ESTADO = Estado;
            PAIS = Pais;
        } 
    }
}