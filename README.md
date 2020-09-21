# .NET Core API Versioning

## Install
``` powershell
PM> Install-Package Microsoft.AspNetCore.Mvc.Versioning -Version 4.1.1
PM> Install-Package Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer -Version 4.1.1
```

## Configuration
``` csharp
public void ConfigureServices(IServiceCollection services)
{
    // ...
    
    services.AddControllers();
    
    services.AddApiVersioning(apiVersioningOptions =>
    {
        apiVersioningOptions.AssumeDefaultVersionWhenUnspecified = true;
        apiVersioningOptions.DefaultApiVersion = new ApiVersion(1, 0);
        apiVersioningOptions.ReportApiVersions = true;
    });
    
    services.AddVersionedApiExplorer(apiExplorerOptions =>
    {
        apiExplorerOptions.GroupNameFormat = "'v'VVVV";
        apiExplorerOptions.SubstituteApiVersionInUrl = true;
    });
    
    // ...
}
```

## Usage
``` csharp
[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}")]
[Produces("application/json")]
public class FooController : ControllerBase
{
    [HttpGet]
    [Route("foo/test")]
    public IActionResult Test()
    {
        return Ok("You requested /api/v1/foo/test");
    }
}
```

``` csharp
[ApiController]
[Route("api/v{version:apiVersion}")]
[Produces("application/json")]
public class BarController : ControllerBase
{
    [HttpGet]
    [ApiVersion("1.0")] // Equivalent of [ApiVersion("1")]
    [Route("bar/test")]
    public IActionResult TestOne()
    {
        return Ok("You requested /api/v1/bar/test");
    }

    [HttpGet]
    [ApiVersion("2.0")] // Equivalent of [ApiVersion("2")]
    [Route("bar/test")]
    public IActionResult TestTwo()
    {
        return Ok("You requested /api/v2/bar/test");
    }
}
```

## Routes
* *Foo API*
  * **api/v1/foo/test**, or equivalent **api/v1.0/foo/test**
* *Bar API*
  * **api/v1/bar/test**, or equivalent **api/v1.0/bar/test**
  * **api/v2/bar/test**, or equivalent **api/v2.0/bar/test**
