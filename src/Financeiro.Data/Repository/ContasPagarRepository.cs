using Financeiro.Domain.Contas;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Data.Repository
{
    public class ContasPagarRepository : Repository<ContasPagas>
    {
        public ContasPagarRepository(ApplicationDbContext context) : base(context)
        {

        }
        public override ContasPagas GetById(int id)
        {
            var query = _context.Set<ContasPagas>().Include(c => c.EMPRESA).Where(e => e.ID == id)
                                                   .Include(f => f.FORNECEDOR).Where(c => c.ID == id)
                                                   .Include(b => b.CONTABANCARIA).Where(f => f.ID == id);

            if (query.Any())
                return query.First();

            return null;
        }

        public override IEnumerable<ContasPagas> GetAll()
        {
            return _context.Set<ContasPagas>().Include(p => p.EMPRESA).Include(a => a.FORNECEDOR).Include(c => c.CONTABANCARIA).AsEnumerable();
        }
    }
}
