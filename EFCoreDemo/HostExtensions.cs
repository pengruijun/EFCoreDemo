using EFCoreDemo.Services;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo;

public static class HostExtensions
{
    public static async Task CreateDbIfNotExists(this IHost host)
    {
        // using (var scope = host.Services.CreateScope())
        // {
        //     var services = scope.ServiceProvider;
        //
        //     var context = services.GetRequiredService<BlogContext>();
        //     var result = await context.Blogs.ToListAsync();
        // }

        // var context = host.Services.GetRequiredService<BlogContext>();
        // var result = await context.Blogs.ToListAsync();

        // var service = host.Services.GetRequiredService<ISingletonService>();
        // service.Result();
        using (var scope = host.Services.CreateScope())
        {
            var service = scope.ServiceProvider.GetRequiredService<SingletonService>();
            service.Result();
        }
    }
}