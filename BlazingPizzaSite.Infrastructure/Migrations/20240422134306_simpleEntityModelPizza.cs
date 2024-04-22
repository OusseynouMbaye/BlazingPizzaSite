using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazingPizzaSite.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class simpleEntityModelPizza : Migration
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

            migrationBuilder.DropColumn(
                name: "DougtType",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "Toppings",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "Vegan",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "Vegetarian",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "size",
                table: "Pizzas");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Pizzas",
                type: "TEXT",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Pizzas",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Pizzas");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Pizzas",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 250);

            migrationBuilder.AddColumn<string>(
                name: "DougtType",
                table: "Pizzas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Pizzas",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Toppings",
                table: "Pizzas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Vegan",
                table: "Pizzas",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Vegetarian",
                table: "Pizzas",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "size",
                table: "Pizzas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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
