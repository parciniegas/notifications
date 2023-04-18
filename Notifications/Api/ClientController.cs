using Microsoft.AspNetCore.Mvc;
using Notifications.Api.DTO;
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

        public ClientController(ILogger logger, IClientService clientService)
        {
            _clientService = clientService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var request = new GetClientByIdRequest(id);
            var client = await _clientService.GetById(request);
            return Ok(client);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateClientDto dto)
        {
            var request = new CreateClientRequest(dto.Name, dto.Description);
            var result = await _clientService.Create(request);

            return Ok(result);
        }
    }
}