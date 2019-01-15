using Financeiro.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Financeiro.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public virtual TEntity GetById(int id)
        {
            return _context.Set<TEntity>().SingleOrDefault(e => e.ID == id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsEnumerable();
        }

        public virtual void Save(TEntity entity)
        {            
            if(entity.ID > 0) // Atualizar Registro
            {
                _context.Update(entity);
            }
            else // Novo Registro
            {
                 _context.Set<TEntity>().Add(entity); 
            }                             
            _context.SaveChanges();
        }
        
    }
}