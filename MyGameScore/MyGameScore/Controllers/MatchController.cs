using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyGameScore.Application.Interfaces;
using MyGameScore.Application.Services.AppMatch.Input;

namespace MyGameScore.Controllers
{
    [Route("api/[controller]")]
    public class MatchController : ControllerBase
    {
        private readonly IMatchApplicationService _matchApplicationService;
        public MatchController(IMatchApplicationService matchApplicationService)
        {
            _matchApplicationService = matchApplicationService;
        }

        [HttpGet]
        [Route("Results")]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)]
        public async Task<IActionResult> GetResults()
        {
            return Ok(await _matchApplicationService.GetResultsAsync());
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)]
        public async Task<IActionResult> Get()
        {
            return Ok(await _matchApplicationService.GetAsync());
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Post([FromBody] MatchInput match)
        {
            var result = await _matchApplicationService.InsertAsync(match);
            if (result != null)
                return Created("", result);

            return BadRequest();
        }

        [HttpDelete]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _matchApplicationService.DeleteAsync(id);
            if (result)
                return Ok();

            return BadRequest();
        }
    }
}