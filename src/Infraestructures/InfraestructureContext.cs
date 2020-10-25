namespace ePizza.WebApi.Infraestructure
{
    using ePizza.WebApi.Model;
    using Microsoft.EntityFrameworkCore;

    public class InfraestructureContext : DbContext 
    {
        public InfraestructureContext(DbContextOptions<InfraestructureContext> options)
            : base(options) { }   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PizzaTopping>()
                .HasKey(k => new { k.PizzaId, k.ToppingId });

            modelBuilder.Entity<PizzaTopping>()
                .HasOne<Pizza>().WithMany(t => t.Toppings);

            modelBuilder.Entity<PizzaTopping>()
                .HasOne(t => t.Topping).WithMany();

            modelBuilder.Entity<PizzaSpecial>()
                .Property(p => p.BasePrice)
                .HasColumnType("decimal(18,2)");

            
            modelBuilder.Entity<Topping>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
        }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<PizzaSpecial> PizzaSpecials { get; set; }
        public DbSet<Topping> Toppings { get; set; }
    }
}
