namespace ePizza.WebApi.v1
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ePizza.WebApi.Common.Utility;
    using ePizza.WebApi.Model;
    using ePizza.WebApi.Service;
    using Microsoft.AspNetCore.Mvc;

    [ApiController, 
    ApiVersion(Versions.v1),
    Route("api/v{version:apiVersion}/specials-pizzas")]
    public class PizzaSpecialController : ControllerBase
    {
        private readonly IPizzaSpecialService _service;

        public PizzaSpecialController(IPizzaSpecialService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [
        //  ProducesResponseType(typeof(BaseResponse), (int)HttpStatusCode.BadRequest),
        //  ProducesResponseType(typeof(BaseResponse), (int)HttpStatusCode.InternalServerError),
        //  ProducesResponseType(typeof(List<PizzaSpecial>), (int)HttpStatusCode.OK),
         HttpGet]
        public async Task<ActionResult<List<PizzaSpecial>>> GetAllPizzaSpecials() 
        {
            var pizzaSpecials = await _service.GetAllAsync()
                ?? new List<PizzaSpecial>();

            return Ok(pizzaSpecials);
        }
    }
}