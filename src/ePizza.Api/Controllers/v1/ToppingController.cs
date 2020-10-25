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
    Route("api/v{version:apiVersion}/toppings")]
    public class ToppingController : ControllerBase
    {
        private readonly IToppingService _service;

        public ToppingController(IToppingService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [
        //     ProducesResponseType(typeof(BaseResponse), (int)HttpStatusCode.BadRequest),
        //  ProducesResponseType(typeof(BaseResponse), (int)HttpStatusCode.InternalServerError),
        //  ProducesResponseType(typeof(List<Topping>), (int)HttpStatusCode.OK),
         HttpGet]
        public async Task<ActionResult<List<Topping>>> GetAllPizzaSpecials() 
        {
            var toppings = await _service.GetAllAsync()
                ?? new List<Topping>();

            return Ok(toppings);
        }
    }    
}
