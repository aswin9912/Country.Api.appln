using Application.Commands;
using Domain.Interface.IQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Country.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly ICity query;

        public CityController(IMediator mediator,ICity query)
        {
            this.mediator = mediator;
            this.query = query;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var citylist=query.GetAllCities();
            return Ok(citylist);
        }
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            if (id ==0)
            {

            return BadRequest(); 
            }
            var citybyid=query.GetCityById(id);
            return Ok(citybyid);
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateCity city)
        {
            var newcity=await mediator.Send(city);
            return Ok(newcity);
        }
        [HttpPut]
        public async Task<IActionResult> Put(int id, UpdateCity city)
        {
            if (city.Id != id)
            {
                return BadRequest();
            }
            var updatecity=await mediator.Send(city);
            return Ok(updatecity);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var delecity=await mediator.Send(new DeleteCity {Id = id});
            return Ok(delecity);
        }

    }
}
