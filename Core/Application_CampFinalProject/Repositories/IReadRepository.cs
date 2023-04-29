using Domain_CampFinalProject.Entities.Common;
using System.Linq.Expressions;

namespace Application_CampFinalProject.Repositories
{
    public interface IReadRepository<T>:IRepository<T> where T : Entity
    {
        IQueryable<T> GetAll(bool tracking = true);
        Task<List<T>> GetAllAsync();
        Task<T?> GetAsync(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);
        Task<T> GetByIdAsync(int id);
    }
}
