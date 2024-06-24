using Api.ErrorResponse;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class ErrorsController(StoreContext context) : BaseController
{
    [HttpGet("notFound")]
    public ActionResult NotFoundResult()
    {
        var category = context.Categories.Find(45);
        if (category == null) return NotFound(new ApiResponse(404));
        return Ok();
    }

    [HttpGet("serverError")]
    public ActionResult ServerErrorMethod()
    {
        var category = context.Categories.Find(45);
        return Ok(category.ToString());
    }

    [HttpGet("badRequest")]
    public ActionResult BadRequestMethod()
    {
        return BadRequest(new ApiResponse(400));
    }

    [HttpGet("badRequest/{id}")]
    public ActionResult BadRequestWithId()
    {
        return Ok();
    }
}