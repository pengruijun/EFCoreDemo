using EFCoreDemo;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using EFCoreDemo.Middlewares;
using EFCoreDemo.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddSingleton<SingletonService>();

builder.Services.AddDbContext<BlogContext>(options =>
    options.UseSqlServer("Data Source=(local); Initial Catalog=EFCoreDemo; Integrated Security=SSPI;"));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers()
    .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<BlogContext>();
    context.Database.EnsureDeleted();
    //context.Database.EnsureCreated();
}

//await app.CreateDbIfNotExists();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UsePrintUrl();
//app.UseMiddleware<PrintUrlMiddleware>();

app.Run();
