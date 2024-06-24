using Application.Commands;
using Domain.Interface.IQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Country.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IState query;

        public StatesController(IMediator mediator,IState query)
        {
            this.mediator = mediator;
            this.query = query;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var statelist=query.GetAllStates();
            return Ok(statelist);
        }
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var state=query.GetState(id);
            return Ok(state);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateState command)
        {
            var newstate=await mediator.Send(command);
            return Ok(newstate);
        }
        [HttpPut]
        public async Task<IActionResult> Update(int id, UpdateState command)
        {
            if (command.Id != id)
            {
                return BadRequest();
            }
            var updatestate=await mediator.Send(command);
            return Ok(updatestate);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var delestate=await mediator.Send(new DeleteState { Id= id });
            return Ok(delestate);
        }
    }
}
