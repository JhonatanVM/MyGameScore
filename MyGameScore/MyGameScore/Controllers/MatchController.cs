using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyGameScore.Application.Interfaces;
using MyGameScore.Application.Services.AppMatch.Input;

namespace MyGameScore.Controllers
{
    /// <summary>
    /// Controller <see cref="MatchController"/>.
    /// </summary>
    [Route("api/[controller]")]
    public class MatchController : ControllerBase
    {
        private readonly IMatchApplicationService _matchApplicationService;

        /// <summary>
        /// Constructor of the Controller <see cref="MatchController"/>.
        /// </summary>
        /// <param name="matchApplicationService"></param>
        public MatchController(IMatchApplicationService matchApplicationService)
        {
            _matchApplicationService = matchApplicationService;
        }

        /// <summary>
        /// Method that gets an analysis of the Matches saved.
        /// </summary>
        /// <returns>Returns an object with the results of the analysis.</returns>
        [HttpGet]
        [Route("Results")]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)]
        public async Task<IActionResult> GetResults()
        {
            return Ok(await _matchApplicationService.GetResultsAsync());
        }

        /// <summary>
        /// Method that gets all Matches saved.
        /// </summary>
        /// <returns>Returns a List of Matches.</returns>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)]
        public async Task<IActionResult> Get()
        {
            return Ok(await _matchApplicationService.GetAsync());
        }

        /// <summary>
        /// Method that insert a new match.
        /// </summary>
        /// <param name="match">Object that is going to be inserted.</param>
        /// <returns>Returns the object inserted.</returns>
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

        /// <summary>
        /// Method that deletes a Match
        /// </summary>
        /// <param name="id">The Id of the Match that is going to be deleted.</param>
        /// <returns></returns>
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