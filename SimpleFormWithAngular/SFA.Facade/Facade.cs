using SFA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFA.Facade
{
    public class Facade<TEntity> : IFacade<TEntity> where TEntity : Entity.Entity
    {
        IRepository<TEntity> repo = null;
     
        public Facade(DataContext context)
        {
            repo = new Repository<TEntity>(context);

        }

        public List<TEntity> GetAll()
        {
            return repo.GetAll();
        }
        public TEntity Get(int id)
        {
            return repo.Get(id);
        }
        public int Update(TEntity Entity)
        {
            return repo.Update(Entity);
        }
        public int Insert(TEntity entity)
        {
            return repo.Insert(entity);
        }
        public int Delete(int id)
        {
            return repo.Delete(id);
        }
    }
}
