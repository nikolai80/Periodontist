using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace periodontist.BLL.Interfaces
{
    public interface IRepository<TEntity> where TEntity:class
    {
        bool Create(TEntity item);
        TEntity FindById(int id);
        IEnumerable<TEntity> GetAll();
        void Remove(TEntity item);
        void Update(TEntity item);
    }
}