using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdopteUnDev.DAL.Interfaces
{
    public interface IRepositoryBase<TEntity, TKey>
    {
        void Create(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(TKey key);
        void Update(TKey key, TEntity entity);
        void Delete(TKey key);
    }
}
