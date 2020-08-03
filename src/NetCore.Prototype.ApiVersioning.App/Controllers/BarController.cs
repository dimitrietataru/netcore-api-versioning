using Microsoft.AspNetCore.Mvc;

namespace NetCore.Prototype.ApiVersioning.App.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public sealed class BarController : ControllerBase
    {
        [HttpGet]
        [Route("api/v1/bar/test-one")]
        public IActionResult TestOne()
        {
            return NoContent();
        }

        [HttpGet]
        [Route("api/v2/foo/test-two")]
        public IActionResult TestTwo()
        {
            return NoContent();
        }
    }
}
