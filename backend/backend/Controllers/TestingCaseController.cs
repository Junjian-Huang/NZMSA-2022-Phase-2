using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestingCaseController : ControllerBase
    {
        /// <summary>
        /// Adds two numbers together
        /// </summary>
        /// <param name="left">The number on the left, which must be a positive integer</param>
        /// <param name="right">The number on the right, which must be a positive integer</param>
        /// <returns>The sum of the input numbers</returns>
        [HttpGet]
        [Route("add")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult GetSum(int left, int right)
        {
            if (left < 0 || right < 0) return BadRequest("The inputs must be greater than zero");

            return Ok(left + right);
        }

    }
}
