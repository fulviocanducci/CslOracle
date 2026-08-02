using Microsoft.EntityFrameworkCore;
using WinForm.DataAccess;

namespace WinForm.Repositories;

public class RepositoryBase<T>(OracleDataAccess context) where T : class, new()
{
    public OracleDataAccess Context { get; private set; } = context;

    public bool Create(T entity)
    {
        if (entity == null) return false;
        Context.Set<T>().Add(entity);
        bool result = Context.SaveChanges() > 0;
        Detach(entity);
        return result;
    }

    public async Task<bool> CreateAsync(T entity)
    {
        if (entity == null) return false;
        await Context.Set<T>().AddAsync(entity);
        bool result = await Context.SaveChangesAsync() > 0;
        Detach(entity);
        return result;
    }

    public bool Update(T entity)
    {
        if (entity == null) return false;
        Context.Set<T>().Update(entity);
        bool result = Context.SaveChanges() > 0;
        Detach(entity);
        return result;
    }

    public async Task<bool> UpdateAsync(T entity)
    {
        if (entity == null) return false;
        Context.Set<T>().Update(entity);
        bool result = await Context.SaveChangesAsync() > 0;
        Detach(entity);
        return result;
    }

    public bool Delete(T entity)
    {
        if (entity == null) return false;
        Context.Set<T>().Remove(entity);
        bool result = Context.SaveChanges() > 0;
        Detach(entity);
        return result;
    }

    public async Task<bool> DeleteAsync(T entity)
    {
        if (entity == null) return false;
        Context.Set<T>().Remove(entity);
        bool result = await Context.SaveChangesAsync() > 0;
        Detach(entity);
        return result;
    }

    public T? Find(params object?[]? keyValues)
    {
        return Context.Set<T>().Find(keyValues);
    }

    public async Task<T?> FindAsync(params object?[]? keyValues)
    {
        return await Context.Set<T>().FindAsync(keyValues);
    }

    public IQueryable<T> Query()
    {
        return Context.Set<T>().AsNoTracking();
    }

    public void Detach(T entity)
    {
        try
        {
            if (entity != null)
            {
                Context.Entry(entity).State = EntityState.Detached;
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
}
