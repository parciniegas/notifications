using Dragonfly.Application.Services;
using Notifications.Domain.Client;
using Notifications.Domain.Client.Commands.Create;
using Notifications.Domain.Client.Queries.GetById;

namespace Notifications.Application.Client;

public class AppClientService : IApplicationService, IAppClientService
{
    private readonly IDomainClientService _clientDomainService;

    public AppClientService(IDomainClientService clientService)
    {
        _clientDomainService = clientService;
    }
    

    public async Task<CreateClientResult> CreateClient(CreateClientCommand command)
    {
        return await _clientDomainService.CreateClient(command);
    }

    public async Task<ClientResult> GetClientById(GetClientByIdQuery query)
    {
        return await _clientDomainService.GetClientById(query);
    }
}