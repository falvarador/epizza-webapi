using ePizza.WebApi.Model;

namespace ePizza.WebApi.Infraestructure
{
    public static class SeedDataOnContext
    {
        public static void Initialize(InfraestructureContext context)
        {
            var pizzas = new PizzaSpecial[]
            {
                new PizzaSpecial 
                {
                    Name = "Pizza clásica de queso",
                    Description = "Es de queso y delicioso. Por qué no querrías una?",
                    BasePrice = 12.99m,
                    ImageUrl = "images/pizzas/cheese.jpg"
                },
                new PizzaSpecial 
                {
                    Name = "Tocinator",
                    Description = "Tiene TODO tipo de tocino",
                    BasePrice = 20.99m,
                    ImageUrl = "images/pizzas/bacon.jpg"
                },
                new PizzaSpecial 
                {
                    Name = "Clásica de pepperoni",
                    Description = "Es la pizza con la que creciste, pero mucho más ardiente",
                    BasePrice = 17.99m,
                    ImageUrl = "images/pizzas/pepperoni.jpg"
                },
                new PizzaSpecial 
                {
                    Name = "Pollo búfalo",
                    Description = "Pollo picante, salsa picante y queso azul, sabor más que garantizado",
                    BasePrice = 14.99m,
                    ImageUrl = "images/pizzas/meaty.jpg"
                },
                new PizzaSpecial 
                {
                    Name = "Amantes del champiñon",
                    Description = "Tiene champiñones. No es obvio?",
                    BasePrice = 15.99m,
                    ImageUrl = "images/pizzas/mushroom.jpg"
                },
                new PizzaSpecial 
                {
                    Name = "Hawaiana",
                    Description = "De piña, jamón y queso...",
                    BasePrice = 12.99m,
                    ImageUrl = "images/pizzas/Hawaiian.jpg"
                },
                new PizzaSpecial 
                {
                    Name = "Delicia vegetariana",
                    Description = "Es como una ensalada, pero en una pizza",
                    BasePrice = 10.99m,
                    ImageUrl = "images/pizzas/salad.jpg"
                },
                new PizzaSpecial 
                {
                    Name = "Margarita",
                    Description = "Pizza italiana tradicional con tomates y albahaca",
                    BasePrice = 18.99m,
                    ImageUrl = "images/pizzas/margherita.jpg"
                }
            };

            var toppings = new Topping[]
            {
                new Topping()
                {
                    Name = "Extra cheese",
                    Price = 2.50m,
                },
                new Topping()
                {
                    Name = "American bacon",
                    Price = 2.99m,
                },
                new Topping()
                {
                    Name = "British bacon",
                    Price = 2.99m,
                },
                new Topping()
                {
                    Name = "Canadian bacon",
                    Price = 2.99m,
                },
                new Topping()
                {
                    Name = "Tea and crumpets",
                    Price = 5.00m
                },
                new Topping()
                {
                    Name = "Fresh-baked scones",
                    Price = 4.50m,
                },
                new Topping()
                {
                    Name = "Bell peppers",
                    Price = 1.00m,
                },
                new Topping()
                {
                    Name = "Onions",
                    Price = 1.00m,
                },
                new Topping()
                {
                    Name = "Mushrooms",
                    Price = 1.00m,
                },
                new Topping()
                {
                    Name = "Pepperoni",
                    Price = 1.00m,
                },
                new Topping()
                {
                    Name = "Duck sausage",
                    Price = 3.20m,
                },
                new Topping()
                {
                    Name = "Venison meatballs",
                    Price = 2.50m,
                },
                new Topping()
                {
                    Name = "Served on a silver platter",
                    Price = 250.99m,
                },
                new Topping()
                {
                    Name = "Lobster on top",
                    Price = 64.50m,
                },
                new Topping()
                {
                    Name = "Sturgeon caviar",
                    Price = 101.75m,
                },
                new Topping()
                {
                    Name = "Artichoke hearts",
                    Price = 3.40m,
                },
                new Topping()
                {
                    Name = "Fresh tomatoes",
                    Price = 1.50m,
                },
                new Topping()
                {
                    Name = "Basil",
                    Price = 1.50m,
                },
                new Topping()
                {
                    Name = "Steak (medium-rare)",
                    Price = 8.50m,
                },
                new Topping()
                {
                    Name = "Blazing hot peppers",
                    Price = 4.20m,
                },
                new Topping()
                {
                    Name = "Buffalo chicken",
                    Price = 5.00m,
                },
                new Topping()
                {
                    Name = "Blue cheese",
                    Price = 2.50m,
                },
            };

            context.Toppings.AddRange(toppings);
            context.PizzaSpecials.AddRange(pizzas);

            context.SaveChanges();
        }
    }
}
