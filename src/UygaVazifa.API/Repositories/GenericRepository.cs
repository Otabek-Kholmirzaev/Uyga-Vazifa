using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using UygaVazifa.API.Data;
using UygaVazifa.API.Repositories.Interfaces;

namespace UygaVazifa.API.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly AppDbContext _context;
    protected DbSet<TEntity> DbSet;

    public GenericRepository(AppDbContext context)
    {
        _context = context;
        DbSet = _context.Set<TEntity>();
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        var entry = await DbSet.AddAsync(entity);

        await _context.SaveChangesAsync();

        return entry.Entity;
    }

    public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression)
        => DbSet.Where(expression);

    public IQueryable<TEntity> GetAll()
        => DbSet;

    public TEntity? GetById(Guid id)
        => DbSet.Find(id);

    public async Task<TEntity> Remove(TEntity entity)
    {
        var entry = DbSet.Remove(entity);

        await _context.SaveChangesAsync();

        return entry.Entity;
    }

    public async Task<TEntity> Update(TEntity entity)
    {
        var entry = DbSet.Update(entity);

        await _context.SaveChangesAsync();

        return entry.Entity;
    }

    public int Save() => _context.SaveChanges();

    public async Task<int> SaveAsync() => await _context.SaveChangesAsync();
}