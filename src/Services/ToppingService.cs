namespace ePizza.WebApi.Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ePizza.WebApi.Infraestructure;
    using ePizza.WebApi.Model;
    using Microsoft.EntityFrameworkCore;

    public class ToppingService : IToppingService
    {
        public async Task<List<Topping>> GetAllAsync()
        {
            return await _context.Toppings.OrderByDescending(o => o.Name).ToListAsync();
        }

        private readonly InfraestructureContext _context;

        public ToppingService(InfraestructureContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}
