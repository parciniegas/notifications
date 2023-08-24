using Dragonfly.Application.Services;
using Notifications.Domain.Client;
using Notifications.Domain.Client.Commands.Create;
using Notifications.Domain.Client.Queries.GetById;

namespace Notifications.Application.Client;

public class AppClientService : IApplicationService, IAppClientService
{
    private readonly IDomainClientService _clientService;

    public AppClientService(IDomainClientService clientService)
    {
        _clientService = clientService;
    }
    

    public async Task<CreateClientResult> CreateClient(CreateClientCommand command)
    {
        return await _clientService.CreateClient(command);
    }

    public async Task<ClientResult> GetClientById(GetClientByIdQuery query)
    {
        return await _clientService.GetClientById(query);
    }
}