using BlazingPizzaSite.Domain.Enums;

namespace BlazingPizzaSite.Domain.Entities
{
    public class Pizza
    {
        public int PizzaId { get; set; }  // Primary key for EF == Id

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string size { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public string DougtType { get; set; } = string.Empty;   // thin, thick, stuffed crust == pâte fine, épaisse, croûte farcie

        public bool Vegetarian { get; set; }

        public bool Vegan { get; set; }

        public Category Category { get; set; }


    }
}