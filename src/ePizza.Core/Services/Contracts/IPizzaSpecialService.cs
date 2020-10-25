namespace ePizza.WebApi.Service
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ePizza.WebApi.Model;

    public interface IPizzaSpecialService
    {
        Task<List<PizzaSpecial>> GetAllAsync();
    }
}
