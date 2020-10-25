namespace ePizza.WebApi.Model
{
    using System.Collections.Generic;

    public class Pizza
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public PizzaSpecial Special { get; set; }
        public int SpecialId { get; set; }
        public int Size { get; set; }
        public List<PizzaTopping> Toppings { get; set; }
    }
}
