using BlazingPizzaSite.Domain.Entities;
using BlazingPizzaSite.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizzaSite.Infrastructure.Context
{
    public class SimplePizzaCatalogDbContext : DbContext
    {
        // db set for pizzas
        public DbSet<Pizza> Pizzas { get; set; }

        public SimplePizzaCatalogDbContext(DbContextOptions<SimplePizzaCatalogDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().HasData(
                new Pizza { PizzaId = Guid.NewGuid(), Name = "Meat Pizza", Description = "Pepperoni, Sausage, Canadian Bacon, Bacon, Mozzarella", Price = 12.50m, Category = Category.Meat, size= Size.Large },
                new Pizza { PizzaId = Guid.NewGuid(), Name = "Chicken Pizza", Description = "Grilled Chicken, BBQ Sauce, Red Onion, Cilantro, Mozzarella", Price = 11.50m, Category = Category.Chicken },
                new Pizza { PizzaId = Guid.NewGuid(), Name = "Vegetarian Pizza", Description = "Mushrooms, Olives, Green Peppers, Onions, Mozzarella", Price = 10.00m, Category = Category.Vegetarian },
                new Pizza { PizzaId = Guid.NewGuid(), Name = "Vegan Pizza", Description = "Mushrooms, Olives, Green Peppers, Onions, Vegan Cheese", Price = 10.00m, Category = Category.Vegan, size = Size.Small},
                new Pizza { PizzaId = Guid.NewGuid(), Name = "Gluten-Free Pizza", Description = "Gluten-Free Crust, Mushrooms, Olives, Green Peppers, Onions, Mozzarella", Price = 14.00m, Category = Category.GlutenFree },
                new Pizza { PizzaId = Guid.NewGuid(), Name = "Nut-Free Pizza", Description = "Mushrooms, Olives, Green Peppers, Onions, Mozzarella", Price = 10.00m, Category = Category.NutFree }
            );
        }
    }
}
