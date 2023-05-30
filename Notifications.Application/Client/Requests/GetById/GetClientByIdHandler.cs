using Dragonfly.Core.Commands;

namespace Notifications.Application.Client.Requests.GetById;

public class GetClientByIdHandler : ICommandHandler<GetClientByIdRequest, ClientResult>
{
    public Task<ClientResult> HandleAsync(GetClientByIdRequest request, CancellationToken cancellationToken = default)
    {
        var client = new ClientResult(1, $"Client {request.Id}", "Client 1 description");

        return Task.FromResult(client);
    }
}