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
            return await _context.Pizzas.OrderByDescending(p=>p.CreatedDate).ToListAsync();
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

        public async Task<Pizza?> GetPizzaByIdAsync(Guid id)
        {
            var pizza = await _context.Pizzas.FirstOrDefaultAsync(p => p.PizzaId == id);
            return pizza;
        }

        public async Task UpdatePizzaAsync(Pizza pizza)
        {
            _context.Entry(pizza).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

       
    }
}
