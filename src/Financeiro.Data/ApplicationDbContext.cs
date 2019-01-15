using Financeiro.Domain.Cadastro;
using Microsoft.EntityFrameworkCore;
using Financeiro.Domain.Dtos;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Financeiro.Data.Identity;
using Financeiro.Domain.Contas;

namespace Financeiro.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }
        public DbSet<Fornecedor> Fornecedor {get; set;}
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Empresa> Empresa { get; set; }   
        public DbSet<ContaBancaria> ContaBancaria { get; set; }    
        public DbSet<CentroCusto> CentroCusto { get; set; }
        public DbSet<ContaCaixa> ContaCaixa { get; set; }
        public DbSet<ContasPagas> ContasPagas { get; set; }
    }
}