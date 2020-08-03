using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace NetCore.Prototype.ApiVersioning.App
{
    public sealed class Program
    {
        public static async Task Main(string[] args)
        {
            await Host
                .CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>())
                .Build()
                .RunAsync()
                .ConfigureAwait(continueOnCapturedContext: false);
        }
    }
}
