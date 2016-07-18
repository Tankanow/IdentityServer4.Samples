using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var url = "http://*:5000";

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls(url)
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
