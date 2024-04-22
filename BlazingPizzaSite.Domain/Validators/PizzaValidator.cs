using BlazingPizzaSite.Domain.Entities;
using FluentValidation;

namespace BlazingPizzaSite.Domain.Validators
{
    public class PizzaValidator //: AbstractValidator<Pizza>
    {
        public PizzaValidator()
        {
           /* RuleFor(p => p.Name).NotEmpty().MaximumLength(50);
            RuleFor(p => p.Description).MaximumLength(100);
            RuleFor(p => p.Category).IsInEnum();
            RuleFor(p => p.Price).GreaterThan(0);
            RuleFor(p => p.DougtType).NotEmpty().MaximumLength(50);
            RuleFor(p => p.size).IsInEnum();        
            RuleFor(p => p.Vegetarian).NotNull();
            RuleFor(p => p.Vegan).NotNull();
            RuleFor(p => p.Toppings).NotNull();*/
        }
    }
}
