using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazingPizzaSite.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class adding_imageUrl_in_db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: new Guid("2c01c03d-d029-4fc4-8330-50acc9d790d2"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: new Guid("5f39e561-1e6c-40f0-a395-8bc50a65cae8"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: new Guid("6f854e8d-3fd4-47d5-9af9-28de82f26224"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: new Guid("81385096-ca34-44bc-8940-63418237e1a5"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: new Guid("8c7b7339-b349-487d-bd4c-d56f72f4d969"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: new Guid("ca37bfa8-9afd-4755-80a6-6e27a4bfebaa"));

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Pizzas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "PizzaId", "Category", "Description", "DougtType", "ImageUrl", "Name", "Price", "Toppings", "Vegan", "Vegetarian", "size" },
                values: new object[,]
                {
                    { new Guid("0d072c12-4556-43ca-9251-8c84b1b6053a"), 5, "Mushrooms, Olives, Green Peppers, Onions, Mozzarella", "", "img/pizzas/mushroom.jpg", "Mushroom Pizza", 10.00m, "[]", false, false, 2 },
                    { new Guid("312c262b-f62e-459f-9796-7704d79e9a98"), 4, "Margherita Crust, Mushrooms, Olives, Green Peppers, Onions, Mozzarella", "", "img/pizzas/margherita.jpg", "Margherita Pizza", 14.00m, "[]", false, false, 2 },
                    { new Guid("32b2da43-8037-4980-974f-2ab24dcebe40"), 2, "Mushrooms, Olives, Green Peppers, Onions, Mozzarella", "", "img/pizzas/pepperoni.jpg", "Vegetarian Pizza", 10.00m, "[]", false, false, 2 },
                    { new Guid("7405716b-47e5-4644-b1f9-78d63ac8bb27"), 3, "Mushrooms, Olives, Green Peppers, Onions, Vegan Cheese", "", "img/pizzas/salad.jpg", "Vegan Pizza", 10.00m, "[]", false, false, 0 },
                    { new Guid("d7bf23a0-723c-4e1e-be5b-bf32cb3f991b"), 0, "Pepperoni, Sausage, Canadian Bacon, Bacon, Mozzarella", "", "img/pizzas/beacon.jpg", "Meat Pizza", 12.50m, "[]", false, false, 2 },
                    { new Guid("f87b7e53-c9d1-4f92-a68b-50d34a01cf10"), 1, "Grilled Chicken, BBQ Sauce, Red Onion, Cilantro, Mozzarella", "", "img/pizzas/meaty.jpg", "Chicken Pizza", 11.50m, "[]", false, false, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: new Guid("0d072c12-4556-43ca-9251-8c84b1b6053a"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: new Guid("312c262b-f62e-459f-9796-7704d79e9a98"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: new Guid("32b2da43-8037-4980-974f-2ab24dcebe40"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: new Guid("7405716b-47e5-4644-b1f9-78d63ac8bb27"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: new Guid("d7bf23a0-723c-4e1e-be5b-bf32cb3f991b"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: new Guid("f87b7e53-c9d1-4f92-a68b-50d34a01cf10"));

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Pizzas");

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "PizzaId", "Category", "Description", "DougtType", "Name", "Price", "Toppings", "Vegan", "Vegetarian", "size" },
                values: new object[,]
                {
                    { new Guid("2c01c03d-d029-4fc4-8330-50acc9d790d2"), 2, "Mushrooms, Olives, Green Peppers, Onions, Mozzarella", "", "Vegetarian Pizza", 10.00m, "[]", false, false, 0 },
                    { new Guid("5f39e561-1e6c-40f0-a395-8bc50a65cae8"), 3, "Mushrooms, Olives, Green Peppers, Onions, Vegan Cheese", "", "Vegan Pizza", 10.00m, "[]", false, false, 0 },
                    { new Guid("6f854e8d-3fd4-47d5-9af9-28de82f26224"), 0, "Pepperoni, Sausage, Canadian Bacon, Bacon, Mozzarella", "", "Meat Pizza", 12.50m, "[]", false, false, 2 },
                    { new Guid("81385096-ca34-44bc-8940-63418237e1a5"), 5, "Mushrooms, Olives, Green Peppers, Onions, Mozzarella", "", "Nut-Free Pizza", 10.00m, "[]", false, false, 0 },
                    { new Guid("8c7b7339-b349-487d-bd4c-d56f72f4d969"), 1, "Grilled Chicken, BBQ Sauce, Red Onion, Cilantro, Mozzarella", "", "Chicken Pizza", 11.50m, "[]", false, false, 0 },
                    { new Guid("ca37bfa8-9afd-4755-80a6-6e27a4bfebaa"), 4, "Gluten-Free Crust, Mushrooms, Olives, Green Peppers, Onions, Mozzarella", "", "Gluten-Free Pizza", 14.00m, "[]", false, false, 0 }
                });
        }
    }
}
