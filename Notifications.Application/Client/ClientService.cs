using Dragonfly.Core.Commands;
using Dragonfly.Core.Services;
using Notifications.Application.Client.Requests.Create;
using Notifications.Application.Client.Requests.GetById;

namespace Notifications.Application.Client;

public class ClientService : IApplicationService, IClientService
{
    private readonly ICommandDispatcher _dispatcher;

    public ClientService(ICommandDispatcher dispatcher) => _dispatcher = dispatcher;

    public async Task<CreateClientResult> CreateClient(CreateClientCommand request)
    {
        var result = await _dispatcher.ExecAsync<CreateClientCommand, CreateClientResult>(request);
        return result;
    }

    public async Task<ClientResult> GetClientById(GetClientByIdRequest request)
    {
        var result = await _dispatcher.ExecAsync<GetClientByIdRequest, ClientResult>(request);
        return result;
    }
}