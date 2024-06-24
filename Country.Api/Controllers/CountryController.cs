using Application.Commands;
using Domain.Interface.IQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Country.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly ICountry query;

        public CountryController(IMediator mediator,ICountry Query)
        {
            this.mediator = mediator;
            query = Query;
        }
        [HttpGet]
        public IActionResult Get()
        {
          var countries=  query.GetCountryList();
            return Ok(countries);
        }
        [HttpGet("1")]
        public IActionResult GetAllCountryStateCity()
        {
            var countryandstate=query.GetCountryStateCity();
            return Ok(countryandstate);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var country=query.GetCountryById(id);
            return Ok(country);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCountry command)
        {
          var newcountry=  await mediator.Send(command);
            return Ok(newcountry);
        }
        [HttpPut]
        public async Task<IActionResult> Put(int id, UpdateCountry command)
        {
            if (command.Id != id)
            {
                return BadRequest();
            }
            var updatedcountry=await mediator.Send(command);
            return Ok(updatedcountry);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var deletecountry=await mediator.Send(new DeleteCountry { Id = id });
            return Ok(deletecountry);
        }
    }
}
