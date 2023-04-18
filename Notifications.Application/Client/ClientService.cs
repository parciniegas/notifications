using Dragonfly.Core.Commands;
using Dragonfly.Core.Services;
using Notifications.Application.Client.Requests.Create;
using Notifications.Application.Client.Requests.GetById;

namespace Notifications.Application.Client;

public class ClientService : IApplicationService, IClientService
{
    private readonly IDispatcher _dispatcher;

    public ClientService(IDispatcher dispatcher)
    {
        _dispatcher = dispatcher;
    }

    public async Task<CreateClientResult> Create(CreateClientRequest request)
    {
        var result = await _dispatcher.DispatchAsync<CreateClientRequest, CreateClientResult>(request);
        return result;
    }

    public async Task<ClientResult> GetById(GetClientByIdRequest request)
    {
        var result = await _dispatcher.DispatchAsync<GetClientByIdRequest, ClientResult>(request);
        return result;
    }
}