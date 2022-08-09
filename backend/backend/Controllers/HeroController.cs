using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroController : ControllerBase
    {
        private readonly HttpClient _client;
        
        /// <summary>
        /// this is the HTTP client
        /// </summary>
        /// <param name="clientFactory"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public HeroController(IHttpClientFactory clientFactory)
        {
            if (clientFactory is null)
            {
                throw new ArgumentNullException(nameof(clientFactory));
            }
            _client = clientFactory.CreateClient("hero");
        }



        /// <summary>
        /// Gets the default Mario JSON object from the API. 
        /// </summary>
        /// <returns>A JSON object with detail from API</returns>
        [HttpGet]
        //[Route("v1/")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetHeroHotPosts()
        {
            var res = await _client.GetAsync("v1/ultimate/characters?name=Mario");
            var content = await res.Content.ReadAsStringAsync();
            return Ok(content);
        }
    }
}
