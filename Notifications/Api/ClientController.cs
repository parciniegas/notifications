using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Notifications.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from ClientController");
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok($"Hello from ClientController with id {id}");
        }

        [HttpPost]
        public IActionResult Post([FromBody] string client)
        {
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}