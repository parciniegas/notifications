using Dragonfly.Application.Services;
using Dragonfly.Cqrs.Commands;
using Dragonfly.Cqrs.Queries;
using Notifications.Application.Client.Queries.GetById;
using Notifications.Application.Client.Requests.Create;

namespace Notifications.Application.Client;

public class ClientService : IApplicationService, IClientService
{
    private readonly ICommandDispatcher _commandDispatcher;
    private readonly IQueryDispatcher _queryDispatcher;

    public ClientService(ICommandDispatcher dispatcher, IQueryDispatcher queryDispatcher)
    {
        _commandDispatcher = dispatcher;
        _queryDispatcher = queryDispatcher;
    }
    

    public async Task<CreateClientResult> CreateClient(CreateClientCommand command)
    {
        var result = await _commandDispatcher.ExecAsync<CreateClientCommand, CreateClientResult>(command);
        return result;
    }

    public async Task<ClientResult> GetClientById(GetClientByIdQuery query)
    {
        var result = await _queryDispatcher.QueryAsync<GetClientByIdQuery, ClientResult>(query);
        return result;
    }
}