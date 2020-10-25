namespace ePizza.WebApi.Model
{
    using FluentValidation;

    public partial class AddPizzaSpecialViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal BasePrice { get; set; }
    }

    public partial class PizzaSpecialValidator : AbstractValidator<AddPizzaSpecialViewModel>
    {
        public PizzaSpecialValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty();
            RuleFor(x => x.Description).NotNull().NotEmpty();
            RuleFor(x => x.BasePrice).NotEmpty();
        }
    }
}
