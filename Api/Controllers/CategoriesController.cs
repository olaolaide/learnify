using Api.Dto;
using AutoMapper;
using Entity;
using Entity.Interfaces;
using Entity.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class CategoriesController(IGenericRepository<Category> repository, IMapper mapper) : BaseController
{
    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<CategoriesDto>>> GetCategories()
    {
        var categories = await repository.GetAllAsync();
        return Ok(mapper.Map<IReadOnlyList<Category>, IReadOnlyList<CategoriesDto>>(categories));
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<CategoryDto>> GetCategory(int id)
    {
        var spec = new CategoriesWithCoursesSpecification(id);
        var category = await repository.GetEntityWithSpec(spec);
        return Ok(mapper.Map<Category, CategoryDto>(category));
    }
}