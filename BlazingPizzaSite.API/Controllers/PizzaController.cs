using BlazingPizzaSite.Application.Interfaces;
using BlazingPizzaSite.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BlazingPizzaSite.API.Controllers
{
    [Route("pizzas")]
    [ApiController]
    //[Route("api/[controller]")]  // [Route("[controller]")] [Route("api/pizza")]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaRepository _pizzaRepository;

        public PizzaController(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository ?? throw new ArgumentNullException(nameof(pizzaRepository));
        }

        [HttpGet]
        public async Task<IEnumerable<Pizza>> GetAllPizzasAsync()
        {
            return await _pizzaRepository.GetAllPizzasAsync();
        }
    }
}
