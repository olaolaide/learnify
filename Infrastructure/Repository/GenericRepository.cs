using Entity.Interfaces;
using Entity.Specifications;
using Infrastructure.Utils;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class GenericRepository<T>(StoreContext context) : IGenericRepository<T> where T : class
{
    public async Task<IReadOnlyList<T>> GetAllAsync()
    {
        return await context.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(dynamic id)
    {
        return await context.Set<T>().FindAsync(id);
    }

    public async Task<T> GetEntityWithSpec(ISpecification<T> spec)
    {
        return await ApplySpec(spec).FirstOrDefaultAsync();
    }

    public async Task<IReadOnlyList<T>> ListWithSpec(ISpecification<T> spec)
    {
        return await ApplySpec(spec).ToListAsync();
    }

    private IQueryable<T> ApplySpec(ISpecification<T> spec)
    {
        return SpecificationEvaluator<T>.GetQuery(context.Set<T>().AsQueryable(), spec);
    }
}