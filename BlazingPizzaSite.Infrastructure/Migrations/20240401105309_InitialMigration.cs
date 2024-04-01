using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazingPizzaSite.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    PizzaId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    size = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    DougtType = table.Column<string>(type: "TEXT", nullable: false),
                    Vegetarian = table.Column<bool>(type: "INTEGER", nullable: false),
                    Vegan = table.Column<bool>(type: "INTEGER", nullable: false),
                    Category = table.Column<int>(type: "INTEGER", nullable: false),
                    Toppings = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.PizzaId);
                });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "PizzaId", "Category", "Description", "DougtType", "Name", "Price", "Toppings", "Vegan", "Vegetarian", "size" },
                values: new object[,]
                {
                    { new Guid("31d10122-574c-4564-aadf-d9d0af852d9d"), 3, "Mushrooms, Olives, Green Peppers, Onions, Vegan Cheese", "", "Vegan Pizza", 10.00m, "[]", false, false, "" },
                    { new Guid("4816d0d8-c2bc-4ee6-b703-de461744c78f"), 2, "Mushrooms, Olives, Green Peppers, Onions, Mozzarella", "", "Vegetarian Pizza", 10.00m, "[]", false, false, "" },
                    { new Guid("60887d37-769c-4962-b9ab-1ce69691da3e"), 0, "Pepperoni, Sausage, Canadian Bacon, Bacon, Mozzarella", "", "Meat Pizza", 12.50m, "[]", false, false, "" },
                    { new Guid("d48d3636-a4b6-4ba9-ada1-dd4208d97e98"), 1, "Grilled Chicken, BBQ Sauce, Red Onion, Cilantro, Mozzarella", "", "Chicken Pizza", 11.50m, "[]", false, false, "" },
                    { new Guid("ddddcd1f-27ec-4987-9bbf-e9308474cadc"), 4, "Gluten-Free Crust, Mushrooms, Olives, Green Peppers, Onions, Mozzarella", "", "Gluten-Free Pizza", 14.00m, "[]", false, false, "" },
                    { new Guid("faf6fe18-9035-4bcb-84ec-50502df3ea3e"), 5, "Mushrooms, Olives, Green Peppers, Onions, Mozzarella", "", "Nut-Free Pizza", 10.00m, "[]", false, false, "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pizzas");
        }
    }
}
