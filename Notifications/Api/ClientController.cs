using Microsoft.AspNetCore.Mvc;
using Notifications.Application.Client;
using Notifications.Domain.Client.Commands.Create;
using Notifications.Domain.Client.Queries.GetById;

namespace Notifications.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IAppClientService _clientService;
        private readonly ILogger<ClientController> _logger;

        public ClientController(ILogger<ClientController> logger, IAppClientService clientService)
        {
            _clientService = clientService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]GetClientByIdQuery request)
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var client = await _clientService.GetClientById(new GetClientByIdQuery(id));
                return Ok(client);
            }
            catch
            {
                _logger.LogError("Error getting client by id");
                return BadRequest();
            }
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var clients = await _clientService.GetClientById(new GetClientByIdQuery(1));
                return Ok(clients);
            }
            catch
            {
                _logger.LogError("Error getting all clients");
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateClientCommand command)
        {
            var result = await _clientService.CreateClient(command);

            return CreatedAtAction(nameof(GetById), new {id = 1}, result);
        }
    }
}