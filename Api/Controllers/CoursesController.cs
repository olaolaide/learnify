using Api.Dto;
using AutoMapper;
using Entity;
using Entity.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class CoursesController(IGenericRepository<Course> repository, IMapper mapper) : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetCourses()
    {
        var courses = await repository.GetAllAsync();
        return Ok(mapper.Map<IReadOnlyList<Course>, IReadOnlyList<CourseDto>>(courses));
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Course>> GetCourse(Guid id)
    {
        var course = await repository.GetByIdAsync(id);
        return Ok(mapper.Map<Course, CourseDto>(course));
    }
}