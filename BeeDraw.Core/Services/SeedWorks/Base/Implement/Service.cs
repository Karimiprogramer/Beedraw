using BeeDraw.Database.Contexts;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore;
using Project.Application.Core.Services.SeedWorks.Base.Interface;
using System.Linq.Expressions;

namespace Project.Application.Core.Services.SeedWorks.Base.Implement;

public class Service<TModel>(ApplicationDbContext _context) : IService<TModel> where TModel : BeeDraw.Database.SeedWorks.Base.EntityBase
{
    private DbSet<TModel> Entities => _context.Set<TModel>();


    public IQueryable<TModel>? GetAsQueryable(bool eager = false)
    {
        try
        {
            IQueryable<TModel> queryable = Entities.AsQueryable();

            if (eager)
            {
                foreach (var property in _context.Model.FindEntityType(typeof(TModel))?.GetNavigations()!) /* getting navigation properties */
                    queryable = queryable.Include(property.Name);
            }

            return queryable;
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public IQueryable<TModel>? GetAsQueryable(Expression<Func<TModel, bool>> expression, bool eager = false)
    {
        try
        {
            IQueryable<TModel> queryable = Entities.Where(expression).AsQueryable();

            if (eager)
            {
                foreach (var property in _context.Model.FindEntityType(typeof(TModel))?.GetNavigations()!) /* getting navigation properties */
                    queryable = queryable.Include(property.Name);
            }

            return queryable;
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<IList<TModel>?> GetListAsync(bool eager = false)
    {
        try
        {
            IQueryable<TModel> queryable = Entities.AsQueryable();

            if (eager)
            {
                foreach (var property in _context.Model.FindEntityType(typeof(TModel))?.GetNavigations()!) /* getting navigation properties */
                    queryable = queryable.Include(property.Name);
            }

            return await queryable.ToListAsync();
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<IList<TModel>?> GetListAsync(Expression<Func<TModel, bool>> expression, bool eager = false)
    {
        try
        {
            IQueryable<TModel> queryable = Entities.AsQueryable();

            if (eager)
            {
                foreach (var property in _context.Model.FindEntityType(typeof(TModel))?.GetNavigations()!) /* getting navigation properties */
                    queryable = queryable.Include(property.Name);
            }

            return await queryable.Where(expression).ToListAsync();
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<TModel?> GetByIdAsync(long id, bool eager = false)
    {
        try
        {
            IQueryable<TModel> queryable = Entities.AsQueryable();

            if (eager)
            {
                foreach (var property in _context.Model.FindEntityType(typeof(TModel))?.GetNavigations()!) /* getting navigation properties */
                    queryable = queryable.Include(property.Name);
            }

            return await queryable.FirstAsync(x => x.Id == id);
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<TModel?> GetFirstAsync(bool eager = false)
    {
        try
        {
            IQueryable<TModel> queryable = Entities.AsQueryable();

            if (eager)
            {
                foreach (var property in _context.Model.FindEntityType(typeof(TModel))?.GetNavigations()!) /* getting navigation properties */
                    queryable = queryable.Include(property.Name);
            }

            return await queryable.FirstAsync();
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<TModel?> GetFirstAsync(Expression<Func<TModel, bool>> expression, bool eager = false)
    {
        try
        {
            IQueryable<TModel> queryable = Entities.AsQueryable();

            if (eager)
            {
                foreach (var property in _context.Model.FindEntityType(typeof(TModel))?.GetNavigations()!) /* getting navigation properties */
                    queryable = queryable.Include(property.Name);
            }

            return await queryable.FirstAsync(expression);
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<TModel?> GetSingleAsync(bool eager = false)
    {
        try
        {
            IQueryable<TModel> queryable = Entities.AsQueryable();

            if (eager)
            {
                foreach (var property in _context.Model.FindEntityType(typeof(TModel))?.GetNavigations()!) /* getting navigation properties */
                    queryable = queryable.Include(property.Name);
            }

            return await queryable.SingleAsync();
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<TModel?> GetSingleAsync(Expression<Func<TModel, bool>> expression, bool eager = false)
    {
        try
        {
            IQueryable<TModel> queryable = Entities.AsQueryable();

            if (eager)
            {
                foreach (var property in _context.Model.FindEntityType(typeof(TModel))?.GetNavigations()!) /* getting navigation properties */
                    queryable = queryable.Include(property.Name);
            }

            return await queryable.SingleAsync(expression);
        }
        catch (Exception e)
        {
            return null;
        }
    }


    public async Task<long?> CreateAsync(TModel entity)
    {
        try
        {
            Entities.Add(entity);
            await _context.SaveChangesAsync();

            return entity.Id;
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<long?> UpdateAsync(TModel entity)
    {
        try
        {
            Entities.Update(entity);
            await _context.SaveChangesAsync();

            return entity.Id;
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<long?> DeleteAsync(TModel entity)
    {
        try
        {
            Entities.Remove(entity);
            await _context.SaveChangesAsync();

            return entity.Id;
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<long?> DeleteAsync(long id)
    {
        try
        {
            var entity = await GetByIdAsync(id);
            return await DeleteAsync(entity);
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public void Dispose()
    {
        _context?.Dispose();
    }
}
