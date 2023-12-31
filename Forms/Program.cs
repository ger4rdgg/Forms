using Forms;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;

public class Program
{
    public static void Main(string[] args)
    {
        //CreateHostBuilder(args).Build().Run();
        var host = CreateHostBuilder(args).Build();

        host.Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}