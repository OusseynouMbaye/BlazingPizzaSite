using BlazingPizzaSite.Domain.Enums;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;
using System;

namespace BlazingPizzaSite.Domain.Entities
{
    public class Pizza
    {
        public Guid PizzaId { get; set; }  // Primary key for EF == Id

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string size { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public string DougtType { get; set; } = string.Empty;   // thin, thick, stuffed crust == pâte fine, épaisse, croûte farcie

        public bool Vegetarian { get; set; }

        public bool Vegan { get; set; }

        public Category Category { get; set; }

        public Toppings[] Toppings { get; set; } = new Toppings[0];  // garniture

    }
}

/*-ProjectName
  - Domain
    - Entities
    - ValueObjects
    - Interfaces
    - Exceptions
  - Application
    - Services
    - DTOs
    - Interfaces
    - Validators
  - Infrastructure
    - Persistence
    - Configuration
    - Mapping
  - Presentation
    - Controllers
    - Views
*/