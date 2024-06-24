using Api.ErrorResponse;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("redirect/{code:int}")]
public class RedirectController : BaseController
{
    [HttpGet]
    public IActionResult Error(int code)
    {
        return new ObjectResult(new ApiResponse(code));
    }
}