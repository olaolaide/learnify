using Api.ErrorResponse;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ErrorsController : BaseController
    {
        private readonly StoreContext _context;

        public ErrorsController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet("notFound")]
        public ActionResult NotFoundResult()
        {
            var category = _context.Categories.Find(45);
            if (category == null) return NotFound(new ApiResponse(404));
            return Ok();
        }

        [HttpGet("serverError")]
        public ActionResult ServerErrorMethod()
        {
            var category = _context.Categories.Find(45);
            return Ok(category?.ToString());
        }

        [HttpGet("badRequest")]
        public ActionResult BadRequestMethod()
        {
            return BadRequest(new ApiResponse(400));
        }

        [HttpGet("badRequest/{id:int}")]
        public ActionResult BadRequestWithId(int id)
        {
            return BadRequest(new ApiValidationErrorResponse());
        }
    }
}