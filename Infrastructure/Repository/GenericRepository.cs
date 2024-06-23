using Entity.Interfaces;
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
}