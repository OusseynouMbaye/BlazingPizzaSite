using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazingPizzaSite.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ajouterSizeInDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: new Guid("182e8618-9e85-4031-8e50-69c284a37ea6"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: new Guid("6f1c9dc4-39e5-4721-bf9d-7080c4230d39"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: new Guid("7e5a1ace-308e-4b1b-9b4b-3a8ebb43961a"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: new Guid("8f51ff61-2031-471a-9a6a-2dd630945768"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: new Guid("c8711552-8c67-49eb-bc33-c40aaff9940a"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: new Guid("eec0db00-0bc6-49bf-a969-0aac7d022bac"));

            migrationBuilder.AlterColumn<int>(
                name: "size",
                table: "Pizzas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "size",
                table: "Pizzas",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "PizzaId", "Category", "Description", "DougtType", "Name", "Price", "Toppings", "Vegan", "Vegetarian", "size" },
                values: new object[,]
                {
                    { new Guid("182e8618-9e85-4031-8e50-69c284a37ea6"), 0, "Pepperoni, Sausage, Canadian Bacon, Bacon, Mozzarella", "", "Meat Pizza", 12.50m, "[]", false, false, 2 },
                    { new Guid("6f1c9dc4-39e5-4721-bf9d-7080c4230d39"), 2, "Mushrooms, Olives, Green Peppers, Onions, Mozzarella", "", "Vegetarian Pizza", 10.00m, "[]", false, false, null },
                    { new Guid("7e5a1ace-308e-4b1b-9b4b-3a8ebb43961a"), 4, "Gluten-Free Crust, Mushrooms, Olives, Green Peppers, Onions, Mozzarella", "", "Gluten-Free Pizza", 14.00m, "[]", false, false, null },
                    { new Guid("8f51ff61-2031-471a-9a6a-2dd630945768"), 1, "Grilled Chicken, BBQ Sauce, Red Onion, Cilantro, Mozzarella", "", "Chicken Pizza", 11.50m, "[]", false, false, null },
                    { new Guid("c8711552-8c67-49eb-bc33-c40aaff9940a"), 3, "Mushrooms, Olives, Green Peppers, Onions, Vegan Cheese", "", "Vegan Pizza", 10.00m, "[]", false, false, 0 },
                    { new Guid("eec0db00-0bc6-49bf-a969-0aac7d022bac"), 5, "Mushrooms, Olives, Green Peppers, Onions, Mozzarella", "", "Nut-Free Pizza", 10.00m, "[]", false, false, null }
                });
        }
    }
}
