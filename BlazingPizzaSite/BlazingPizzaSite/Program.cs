using BlazingPizzaSite.Application.Interfaces;
using BlazingPizzaSite.Components;
using BlazingPizzaSite.Infrastructure.Context;
using BlazingPizzaSite.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Information)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .WriteTo.File("logs/pizzaSite.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Services.AddDbContextFactory<SimplePizzaCatalogDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("SimplePizzaCatalogConnection"));
});


builder.Services.AddScoped<IPizzaRepository, PizzaRepository>();

/*builder.Services.AddScoped(sp => new HttpClient
{ BaseAddress = new Uri(builder.Configuration["BaseUrl"]) 
});*/

builder.Host.UseSerilog();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BlazingPizzaSite.Client._Imports).Assembly);

app.Run();
