using BlazingPizzaSite.Application.Interfaces;
using BlazingPizzaSite.Infrastructure.Context;
using BlazingPizzaSite.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContextFactory<SimplePizzaCatalogDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("SimplePizzaCatalogConnection"));
});

builder.Services.AddScoped<IPizzaRepository, PizzaRepository>();


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "BlazingPizzaSite.API", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
