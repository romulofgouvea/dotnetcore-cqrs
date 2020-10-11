using Microsoft.AspNetCore.Mvc;

namespace cqrs.Aplication.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        [HttpGet]
        public IActionResult Read()
        {
            return Ok("Ok");
        }
    }
}
