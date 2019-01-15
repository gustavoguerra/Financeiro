using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Financeiro.Data;
using Financeiro.Data.Identity;
using Financeiro.Domain;
using Financeiro.Domain.Cadastro;
using Microsoft.AspNetCore.Identity;
using Financeiro.Domain.Account;
using Financeiro.Domain.Contas;
using Financeiro.Data.Repository;

namespace Financeiro.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string conection)
        {
            services.AddDbContext<ApplicationDbContext>(Base64FormattingOptions => Base64FormattingOptions.UseSqlServer(conection));

            services.AddIdentity<ApplicationUser, IdentityRole>(config =>
            {
                config.Password.RequireDigit = false;
                config.Password.RequiredLength = 4;
                config.Password.RequireLowercase = false;
                config.Password.RequireNonAlphanumeric = false;
                config.Password.RequireUppercase = false;
            })
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                // options.LoginPath = "/Identity/Account/Login";
                // options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            services.AddScoped(typeof(IRepository<ContaBancaria>), typeof(ContaBancariaRepository));
            services.AddScoped(typeof(IRepository<ContasPagas>), typeof(ContasPagarRepository));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IAuthentication), typeof(Authentication));
            services.AddScoped(typeof(IManager), typeof(Manager));
            services.AddScoped(typeof(FornecedorStorer));
            services.AddScoped(typeof(ClienteStorer));
            services.AddScoped(typeof(EmpresaStorer));
            services.AddScoped(typeof(ContaBancariaStore));
            services.AddScoped(typeof(CentroCustoStore));
            services.AddScoped(typeof(ContaCaixaSotore));
        }
    }
}
