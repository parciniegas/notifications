using Dragonfly.Cqrs.Queries;

namespace Notifications.Domain.Client.Queries.GetById;

public class GetClientByIdQueryHandler : IQueryHandler<GetClientByIdQuery, ClientResult>
{
    public Task<ClientResult> HandleAsync(GetClientByIdQuery request, CancellationToken cancellationToken = default)
    {
        var client = new ClientResult($"Client {request.Id}, Client 1 description");

        return Task.FromResult(client);
    }
}