using Dependency_Injection;
using Dependency_Injection.CustomDependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

#region Custom Dependency Injection
var serviceCollection = new DIServiceCollection();

//serviceCollection.AddSingleton<IGuidGenerator, GuidGenerator>();
serviceCollection.AddTransient<IGuidGenerator, GuidGenerator>();
//serviceCollection.AddTransient<GuidGenerator>();
//serviceCollection.AddSingleton<GuidGenerator>();
//serviceCollection.AddSingleton(new GuidGenerator());
var container = serviceCollection.GenerateContainer();
//var service = container.GetService<GuidGenerator>();
//var service2 = container.GetService<GuidGenerator>();

var service = container.GetService<IGuidGenerator>();
var service2 = container.GetService<IGuidGenerator>();
var guid = service.RandomGuid();
var guid2 = service2.RandomGuid();
#endregion





var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
