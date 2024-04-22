using BlazingPizzaSite.Application.Interfaces;
using BlazingPizzaSite.Domain.Entities;
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

       

        public async Task<IEnumerable<Pizza>> GetAllPizzasAsync()
        {
            return await _context.Pizzas.ToListAsync();
        }

        /* public async Task<List<Pizza>> GetAllPizzaAsync()
         {
             return await _context.Pizzas.ToListAsync();
         }*/

        public async Task AddPizzaAsync(Pizza pizza)
        {      
            _context.Pizzas.Add(pizza);
            await _context.SaveChangesAsync();
        }
    }
}
