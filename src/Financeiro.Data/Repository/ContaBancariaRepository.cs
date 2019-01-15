using System.Collections.Generic;
using System.Linq;
using Financeiro.Domain.Cadastro;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Data.Repository
{
    public class ContaBancariaRepository : Repository<ContaBancaria>
    {
        public ContaBancariaRepository(ApplicationDbContext context) : base(context)
        {

        }
        public override ContaBancaria GetById(int id)
        {
            var query = _context.Set<ContaBancaria>().Include(p => p.EMPRESA).Where(e => e.ID == id);

            if(query.Any())
                return query.First();

            return null;
        }

        public override IEnumerable<ContaBancaria> GetAll()
        {
            // var query = _context.Set<ContaBancaria>().Include(p => p.EMPRESA);
            // return query.Any() ? query.ToList() : new List<ContaBancaria>();
            return _context.Set<ContaBancaria>().Include(p => p.EMPRESA).AsEnumerable();
        }
    }
}