namespace MonSite.Library.Interfaces;

public interface IRepositoryBase<TEntity, TKey>
        where TEntity : class
{
    IEnumerable<TEntity> GetAll();
    TEntity? GetById(TKey key);
    TEntity? Insert(TEntity entity);
    bool Update(TKey key, TEntity entity);
    bool Delete(TKey key);
}
