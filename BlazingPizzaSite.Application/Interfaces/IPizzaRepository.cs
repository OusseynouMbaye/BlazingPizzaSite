using BlazingPizzaSite.Domain.Entities;

namespace BlazingPizzaSite.Application.Interfaces
{
    public interface IPizzaRepository
    {

        // get all pizzas
        //Task<Pizza[]> GetPizzasAsync();
        Task<IEnumerable<Pizza>> GetAllPizzasAsync();

        //Task<List<Pizza>> GetAllPizzaAsync();
        //Task AddPizzaAsync(Pizza pizza);

    }
}
