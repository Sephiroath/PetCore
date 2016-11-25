using System.Collections.Generic;
using DataAccess.Repositories.Contracts._Base;

namespace DataAccess.Repositories._base
{
    public class BaseRepository<T, TU> : IBaseRepository<T, TU>
        where T : class
        where TU : class
    {
        public int Create(TU entity)
        {
            throw new System.NotImplementedException();
        }

        public T Get(TU id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> List()
        {
            throw new System.NotImplementedException();
        }

        public T Update(TU entity)
        {
            throw new System.NotImplementedException();
        }

        public T Delete(TU id)
        {
            throw new System.NotImplementedException();
        }
    }
}