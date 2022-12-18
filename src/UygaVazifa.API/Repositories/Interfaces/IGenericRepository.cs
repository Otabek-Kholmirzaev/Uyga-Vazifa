using System.Linq.Expressions;

namespace UygaVazifa.API.Repositories.Interfaces;

public interface IGenericRepository<TEntity> where TEntity : class
{
    TEntity? GetById(Guid id);
    IQueryable<TEntity> GetAll();
    IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression);
    Task<TEntity> AddAsync(TEntity entity);
    Task<TEntity> Remove(TEntity entity);
    Task<TEntity> Update(TEntity entity);
    int Save();
    Task<int> SaveAsync();
}