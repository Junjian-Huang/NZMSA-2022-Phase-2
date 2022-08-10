using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestingCaseController : ControllerBase
    {
        /// <summary>
        /// Input a positive number
        /// </summary>
        /// <param name="positiveNumber">The number must be a positive integer</param>
        /// <returns>Number greater than zero</returns>
        [HttpGet]
        [Route("add")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult TestingStatus(int positiveNumber)
        {
            if (positiveNumber <= 0) return BadRequest("The inputs must be greater than zero");

            return Ok("The inputs greater than zero");
        }

    }
}
