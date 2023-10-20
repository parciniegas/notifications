using Dragonfly.Application.Services;
using Dragonfly.CQRS.Commands;
using Dragonfly.CQRS.Queries;
using Notifications.Domain.Client.Commands.Create;
using Notifications.Domain.Client.Queries.GetById;

namespace Notifications.Application.Client;

public class AppClientService : IApplicationService, IAppClientService
{
    private readonly ICommandDispatcher _commandDispatcher;
    private readonly IQueryDispatcher _queryDispatcher;

    public AppClientService(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
    {
        _commandDispatcher = commandDispatcher;
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