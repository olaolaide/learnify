using Entity;
using Entity.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class CategoryRepository(StoreContext context) : ICategoryRepository
{
    public async Task<IReadOnlyList<Category>> GetCategoriesAsync()
    {
        return await context.Categories.Include(x => x.Courses).ToListAsync();
    }

    public async Task<Category> GetCategoryByIdAsync(int id)
    {
        return await context.Categories.Include(x => x.Courses).FirstOrDefaultAsync(x => x.Id == id);
    }
}