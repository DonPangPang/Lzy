using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Lzy.Framework;

public static class LzyExtensions
{
    private static List<string> _openModules = new();

    public static IServiceCollection AddLzy(this IServiceCollection services)
    {
        _openModules.Add("Swagger");
        return services;
    }

    public static IApplicationBuilder UseLzy(this IApplicationBuilder app)
    {
        _openModules.Add("Cors");
        
        Console.WriteLine("---------> Thanks for using Lzy Framework <---------");
        Console.WriteLine($"-\tHad open modules: [{string.Join(',', _openModules)}]");
        Console.WriteLine("---------> Thanks for using Lzy Framework <---------");
        return app;
    }
}