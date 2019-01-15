using System.Threading.Tasks;
using Financeiro.Domain.Account;
using Microsoft.AspNetCore.Identity;

namespace Financeiro.Data.Identity
{
    public class Authentication : IAuthentication
    {
        private readonly SignInManager<ApplicationUser> _signinmaneger;

        public Authentication(SignInManager<ApplicationUser> signinmaneger)
        {
            _signinmaneger = signinmaneger;
        }
        
        public async Task<bool> Authenticate(string email, string password)
        {
            var result = await _signinmaneger.PasswordSignInAsync(email,password, false, lockoutOnFailure : false);

            return result.Succeeded;
        }

        public async Task Logout()
        {
            await _signinmaneger.SignOutAsync();
        }
    }
}