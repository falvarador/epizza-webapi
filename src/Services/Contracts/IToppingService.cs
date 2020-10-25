namespace ePizza.WebApi.Service
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ePizza.WebApi.Model;

    public interface IToppingService
    {
        Task<List<Topping>> GetAllAsync();
    }
}
