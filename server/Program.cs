using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Peachpie.Web;

namespace Server
{
    public static class Program
    {
        static void Main()
        {
            var root = Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()) + "/website";

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseWebRoot(root).UseContentRoot(root) // content root with wp static files
                .UseUrls("http://*:5004/") 
                .UseStartup<Startup>() // initialization routine, see below
                .Build();

            host.Run();
        }

    }
 
    public class Startup
    {
        public void Configure(IApplicationBuilder app) {
            Pchp.Core.Context.DefaultErrorHandler = new Pchp.Core.CustomErrorHandler(); // disables debug asserts

            app.UsePhp(); // installs handler for *.php files and forwards them to our website.dll
            app.UseDefaultFiles();
            app.UseStaticFiles();

        }
    }
}