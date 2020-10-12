using cqrs.Domain.Commands.Requests;
using cqrs.Domain.Commands.Response;
using cqrs.Domain.Models;
using cqrs.Domain.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cqrs.Aplication.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        [HttpGet]
        [Route("read")]
        public async Task<IActionResult> Read([FromServices] IMediator mediator)
        {
            try
            {
                GetAllCandidateQuery query = new GetAllCandidateQuery();

                IEnumerable<MCandidate> result = await mediator.Send(query);

                return Ok(result);
            }
            catch
            {
                return BadRequest("Não foi possivel criar os dados!");
            }
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create([FromServices] IMediator mediator, [FromBody] CreateCandidateCommandRequest command)
        {
            try
            {
                CreateCandidateCommandResponse result = await mediator.Send(command);
                return Ok(result);
            }
            catch
            {
                return BadRequest("Não foi possivel criar os dados!");
            }
        }
    }
}
