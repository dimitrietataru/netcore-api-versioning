using Microsoft.AspNetCore.Mvc;

namespace NetCore.Prototype.ApiVersioning.App.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public sealed class FooController : ControllerBase
    {
        [HttpGet]
        [Route("api/v1/foo/test")]
        public IActionResult Test()
        {
            return NoContent();
        }
    }
}
