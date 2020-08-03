using Microsoft.AspNetCore.Mvc;

namespace NetCore.Prototype.ApiVersioning.App.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}")]
    [Produces("application/json")]
    public sealed class BarController : ControllerBase
    {
        [HttpGet]
        [ApiVersion("1.0")]
        [Route("bar/test")]
        public IActionResult TestOne()
        {
            return Ok("You requested /api/v1/bar/test");
        }

        [HttpGet]
        [ApiVersion("2.0")]
        [Route("bar/test")]
        public IActionResult TestTwo()
        {
            return Ok("You requested /api/v2/bar/test");
        }
    }
}
