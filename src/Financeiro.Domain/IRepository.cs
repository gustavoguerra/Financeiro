using System.Collections.Generic;

namespace Financeiro.Domain
{
    public interface IRepository<TEntity>
    {
         TEntity GetById(int id);

         IEnumerable<TEntity> GetAll();

         void  Save(TEntity entity);
    }
}