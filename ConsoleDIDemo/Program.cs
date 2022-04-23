// See https://aka.ms/new-console-template for more information

using ConsoleDIDemo;
using ConsoleDIDemo.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder()
    .ConfigureServices((_, services) =>
    {
        services.AddTransient<ITransientOperation, OperationDefault>();
        services.AddScoped<IScopedOperation, OperationDefault>();
        services.AddSingleton<ISingletonOperation, OperationDefault>();
        services.AddScoped<OperationLogger>();
    });

// var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddTransient<ITransientOperation, OperationDefault>();
// builder.Services.AddScoped<IScopedOperation, OperationDefault>();
// builder.Services.AddSingleton<ISingletonOperation, OperationDefault>();
// builder.Services.AddScoped<OperationLogger>();


var host = builder.Build();
var test = host.Services.GetRequiredService<OperationLogger>();
test.Operations("test");
//ExemplifyScoping(host.Services);

//host.Run();

void ExemplifyScoping(IServiceProvider services)
{
    // var test = services.GetRequiredService<ISingletonOperation>();
    // Console.WriteLine(test.OperationId);
    //
    // Console.WriteLine("..................");
    //
    // test = services.GetRequiredService<ISingletonOperation>();
    // Console.WriteLine(test.OperationId);
    //
    // Console.WriteLine("..................");
    //
    // test = services.GetRequiredService<ISingletonOperation>();
    // Console.WriteLine(test.OperationId);
    
    var test = services.GetRequiredService<OperationLogger>();
    test.Operations("test");
    
    // Console.WriteLine("..................");
    //
    // test = services.GetRequiredService<ITransientOperation>();
    // Console.WriteLine(test.OperationId);
    //
    // Console.WriteLine("..................");
    //
    // test = services.GetRequiredService<ITransientOperation>();
    // Console.WriteLine(test.OperationId);
    
    // var operationLogger = services.GetRequiredService<OperationLogger>();
    // operationLogger.Operations("test");

     var serviceProvider = services.CreateScope().ServiceProvider;
    // var operationLogger = serviceProvider.GetRequiredService<OperationLogger>();
    //
    // operationLogger.Operations("scope 1");
    // Console.WriteLine();
    //
    // operationLogger = serviceProvider.GetRequiredService<OperationLogger>();
    // operationLogger.Operations("scope 2");
    // Console.WriteLine();
}

//Console.WriteLine("Hello, World!");