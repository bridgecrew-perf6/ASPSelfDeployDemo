using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MonSite.Library.Interfaces;

namespace MonSite.Library.Repositories;

public class RepositoryBase<TEntity, TKey> : IRepositoryBase<TEntity, TKey>
    where TEntity : class
{
    protected readonly EFContext _context;

    public RepositoryBase(EFContext context)
    {
        _context = context;
    }

    public IEnumerable<TEntity> GetAll()
    {
        return _context.Set<TEntity>();
    }

    public TEntity? GetById(TKey key)
    {
        return _context.Find<TEntity>(key);
    }

    public TEntity? Insert(TEntity entity)
    {
        TEntity saved = _context.Add(entity).Entity;
        _context.SaveChanges();
        return saved;
    }

    public bool Update(TKey key, TEntity entity)
    {
        EntityEntry entry = _context.Entry(entity);
        entry.State = EntityState.Modified;
        return _context.SaveChanges() > 0;
    }

    public bool Delete(TKey key)
    {
        TEntity? entity = _context.Find<TEntity>(key);
        if (entity is null) return false;
        _context.Remove(entity);
        return _context.SaveChanges() > 0;
    }
}
