using Api.Dto;
using AutoMapper;
using Entity;
using Entity.Interfaces;
using Entity.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class CoursesController(IGenericRepository<Course> repository, IMapper mapper) : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetCourses(string sort)
    {
        var spec = new CoursesWithCategoriesSpecification(sort);
        var courses = await repository.ListWithSpec(spec);
        return Ok(mapper.Map<IReadOnlyList<Course>, IReadOnlyList<CourseDto>>(courses));
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Course>> GetCourse(Guid id)
    {
        var spec = new CoursesWithCategoriesSpecification(id);
        var course = await repository.GetEntityWithSpec(spec);
        return Ok(mapper.Map<Course, CourseDto>(course));
    }
}