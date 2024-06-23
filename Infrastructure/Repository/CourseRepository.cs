using Entity;
using Entity.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class CourseRepository(StoreContext context) : ICourseRepository
{
    public async Task<Course> GetCourseByIdAsync(Guid id)
    {
        var course = await context.Courses
            .Include(x => x.Category)
            .Include(x => x.Learning)
            .Include(x => x.Requirements)
            .FirstOrDefaultAsync(x => x.Id == id);
        return course ?? throw new Exception("Element is not found");
    }

    public async Task<IReadOnlyList<Course>> GetCoursesAsync()
    {
        return await context.Courses.Include(x => x.Category).ToListAsync();
    }
}