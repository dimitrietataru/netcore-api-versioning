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
            string requestPath = HttpContext.Request.Path;
            string response = $"Echo from { requestPath }";

            return Ok(response);
        }

        [HttpGet]
        [ApiVersion("2.0")]
        [Route("bar/test")]
        public IActionResult TestTwo()
        {
            string requestPath = HttpContext.Request.Path;
            string response = $"Echo from { requestPath }";

            return Ok(response);
        }
    }
}
