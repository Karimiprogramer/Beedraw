using BeeDraw.Database.SeedWorks.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BeeDraw.Core.Services.SeedWorks.Base.Interface;

public interface IService<TModel> : IDisposable where TModel : EntityBase
{
    IQueryable<TModel>? GetAsQueryable(bool eager = false);
    IQueryable<TModel>? GetAsQueryable(Expression<Func<TModel, bool>> expression, bool eager = false);


    Task<IList<TModel>?> GetListAsync(bool eager = false);
    Task<IList<TModel>?> GetListAsync(Expression<Func<TModel, bool>> expression, bool eager = false);


    Task<TModel?> GetFirstAsync(bool eager = false);
    Task<TModel?> GetFirstAsync(Expression<Func<TModel, bool>> expression, bool eager = false);


    Task<TModel?> GetSingleAsync(bool eager = false);
    Task<TModel?> GetSingleAsync(Expression<Func<TModel, bool>> expression, bool eager = false);


    Task<TModel?> GetByIdAsync(long id, bool eager = false);


    Task<long?> CreateAsync(TModel model);

    Task<long?> UpdateAsync(TModel model);

    Task<long?> DeleteAsync(TModel model);

    Task<long?> DeleteAsync(long id);
}
