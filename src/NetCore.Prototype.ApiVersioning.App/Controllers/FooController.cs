﻿using Microsoft.AspNetCore.Mvc;

namespace NetCore.Prototype.ApiVersioning.App.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [Produces("application/json")]
    public sealed class FooController : ControllerBase
    {
        [HttpGet]
        [Route("foo/test")]
        public IActionResult Test()
        {
            return Ok("You requested /api/v1/foo/test");
        }
    }
}
