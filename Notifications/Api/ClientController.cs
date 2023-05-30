using Microsoft.AspNetCore.Mvc;
using Notifications.Application.Client;
using Notifications.Application.Client.Requests.Create;
using Notifications.Application.Client.Requests.GetById;

namespace Notifications.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly ILogger _logger;

        public ClientController(ILogger<ClientController> logger, IClientService clientService)
        {
            _clientService = clientService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]GetClientByIdRequest request)
        {
            try
            {
                var client = await _clientService.GetClientById(request);
                return Ok(client);
            }
            catch
            {
                _logger.LogError("Error getting client by id");
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateClientCommand command)
        {
            var result = await _clientService.CreateClient(command);

            return Ok(result);
        }
    }
}