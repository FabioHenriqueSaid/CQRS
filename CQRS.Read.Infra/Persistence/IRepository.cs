using System;
using System.Linq;
using System.Linq.Expressions;

namespace CQRS.Read.Infra.Persistence
{
    public interface IRepository<T>
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(object id);
        IQueryable<T> Get(Expression<Func<T, bool>> predicate = null);
        T Find(object id);
    }
}