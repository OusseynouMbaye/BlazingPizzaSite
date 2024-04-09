using Microsoft.EntityFrameworkCore;

namespace BlazingPizza2.Data
{
    public class PizzaStoreContext : DbContext
    {
        public PizzaStoreContext(DbContextOptions<PizzaStoreContext> options)
            : base(options)
        {
        }

        public DbSet<PizzaSpecial> Specials { get; set; }

        /* public DbSet<Topping> Toppings { get; set; }

         public DbSet<Order> Orders { get; set; }

         public DbSet<OrderPizza> Pizzas { get; set; }

         public DbSet<User> Users { get; set; }*/

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<PizzaSpecial>().HasData(
        //                    new PizzaSpecial
        //                    {
        //                        Id = 1,
        //                        Name = "Pizza Margherita",
        //                        BasePrice = 8.50m,
        //                        Description = "The classic. San Marzano tomatoes, fresh mozzarella, basil, olive oil.",
        //                        ImageUrl = "img/margherita.jpg"
        //                    },
        //                    new PizzaSpecial
        //                    {
        //                        Id = 2,
        //                        Name = "Pizza Pepperoni",
        //                        BasePrice = 10.50m,
        //                        Description = "The classic. San Marzano tomatoes, fresh mozzarella, basil, olive oil.",
        //                        ImageUrl = "img/pepperoni.jpg"
        //                    },
        //                    new PizzaSpecial
        //                    {
        //                        Id = 3,
        //                        Name = "Pizza Ham and Pineapple",
        //                        BasePrice = 11.50m,
        //                        Description = "The classic. San Marzano tomatoes, fresh mozzarella, basil, olive oil.",
        //                        ImageUrl = "img/hamandpineapple.jpg"
        //                    },
        //                    new PizzaSpecial
        //                    {
        //                        Id = 4,
        //                        Name = "Pizza Meat Feast",
        //                        BasePrice = 12.50m,
        //                        Description = "The classic. San Marzano tomatoes, fresh mozzarella, basil, olive oil.",
        //                        ImageUrl = "img/meatfeast.jpg"
        //                    });

        //    modelBuilder.Entity<Topping>().HasData(
        //                       new Topping { Id = 1, Name = "Extra cheese" },
        //                            new Topping { Id = 2, Name = "Mushrooms" },
        //                            new Topping { Id = 3, Name = "Green peppers" },
        //                            new Topping { Id = 4, Name = "Black olives" },
        //                            new Topping { Id = 5, Name = "Pepperoni" },
        //                            new Topping { Id = 6, Name = "Pineapple" });
        //}
    }


}
