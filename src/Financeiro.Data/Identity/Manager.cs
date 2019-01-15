using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financeiro.Domain.Account;
using Microsoft.AspNetCore.Identity;

namespace Financeiro.Data.Identity
{
    public class Manager : IManager
    {
        private readonly UserManager<ApplicationUser> _usermanager;

        private readonly SignInManager<ApplicationUser> _singinmanager;

        public readonly ApplicationDbContext _dbcontex; 

        public Manager(UserManager<ApplicationUser> usermanager, SignInManager<ApplicationUser> siginmanager, ApplicationDbContext dbcontext)
        {
            _usermanager = usermanager;
            _singinmanager =siginmanager;
            _dbcontex = dbcontext;
        }
        public async Task<bool> CreateAsync(string email, string password, string role)
        {
            var user = new ApplicationUser {UserName = email, Email = email};
            var result = await _usermanager.CreateAsync(user,password);

            if(result.Succeeded)
            {
                await _usermanager.AddToRoleAsync(user,role);
                return true;
            }
            return false;
        }

        public List<IUser> ListAll()
        {
            var user = _dbcontex.Users;

            return user.Any() ? user.Select(u => (IUser)u).ToList() : new List<IUser>();
        }
    }
}