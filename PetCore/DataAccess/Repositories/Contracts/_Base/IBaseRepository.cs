using System.Collections.Generic;

namespace DataAccess.Repositories.Contracts._Base
{
    public interface IBaseRepository<out T, in TU>
        where T : class
        where TU : class
    {
        int Create(TU entity);
        T Get(TU entity);
        IEnumerable<T> List();
        T Update(TU entity);
        T Delete(TU entity);
    }
}