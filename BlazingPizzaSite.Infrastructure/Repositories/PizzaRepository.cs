using BlazingPizzaSite.Application.Interfaces;
using BlazingPizzaSite.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizzaSite.Infrastructure.Repositories
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly SimplePizzaCatalogDbContext _context;
        public PizzaRepository(IDbContextFactory<SimplePizzaCatalogDbContext> factory)
        {
            _context = factory.CreateDbContext();
        }
    }
}
