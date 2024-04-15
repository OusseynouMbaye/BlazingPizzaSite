using BlazingPizzaSite.Application.Interfaces;
using BlazingPizzaSite.Components;
using BlazingPizzaSite.Infrastructure.Context;
using BlazingPizzaSite.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddRazorPages();

builder.Services.AddDbContextFactory<SimplePizzaCatalogDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("SimplePizzaCatalogConnection"));
});

builder.Services.AddScoped<IPizzaRepository, PizzaRepository>();

/*builder.Services.AddScoped(sp => new HttpClient
{ BaseAddress = new Uri(builder.Configuration["BaseUrl"]) 
});*/



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

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BlazingPizzaSite.Client._Imports).Assembly);

app.Run();
