using Api.Dto;
using AutoMapper;
using Entity;
using Entity.Interfaces;
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
        var category = await repository.GetByIdAsync(id);
        return Ok(mapper.Map<Category, CategoryDto>(category));
    }
}