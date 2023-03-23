using System.Linq.Expressions;

namespace InstaDough.Core.Repository
{
    public interface IRepository<T>
    {
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        IEnumerable<T> GetAll();
        IEnumerable<T> GelAllWith(object param);
        IEnumerable<T> GelAllWith(Expression<Func<T, bool>> Expression);
    }
}
