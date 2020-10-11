using Microsoft.AspNetCore.Mvc;
using MediatR;
using cqrs.Domain.Commands.Requests;
using System.Threading.Tasks;

namespace cqrs.Aplication.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        [HttpGet]
        [Route("read")]
        public IActionResult Read()
        {
            return Ok("Ok");
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create([FromServices] IMediator mediator, [FromBody] CreateCandidateCommandRequest command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
    }
}
