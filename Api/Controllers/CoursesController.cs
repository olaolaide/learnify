using Entity;
using Entity.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class CoursesController(ICourseRepository repository) : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetCourses()
    {
        var courses = await repository.GetCoursesAsync();
        return Ok(courses);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Course>> GetCourse(Guid id)
    {
        return await repository.GetCourseByIdAsync(id);
    }
}