namespace ePizza.WebApi.Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ePizza.WebApi.Infraestructure;
    using ePizza.WebApi.Model;
    using Microsoft.EntityFrameworkCore;

    public class PizzaSpecialService : IPizzaSpecialService
    {
        public async Task<List<PizzaSpecial>> GetAllAsync()
        {
            return await _context.PizzaSpecials.OrderByDescending(o => o.BasePrice).ToListAsync();
        }

        private readonly InfraestructureContext _context;

        public PizzaSpecialService(InfraestructureContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}
