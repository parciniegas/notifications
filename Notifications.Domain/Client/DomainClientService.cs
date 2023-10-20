using Dragonfly.CQRS.Commands;
using Dragonfly.CQRS.Queries;
using Notifications.Domain.Client.Commands.Create;
using Notifications.Domain.Client.Queries.GetById;

namespace Notifications.Domain.Client;

public class DomainClientService: IDomainClientService
{
    private readonly ICommandDispatcher _commandDispatcher;
    private readonly IQueryDispatcher _queryDispatcher;

    public DomainClientService(ICommandDispatcher dispatcher, IQueryDispatcher queryDispatcher)
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
