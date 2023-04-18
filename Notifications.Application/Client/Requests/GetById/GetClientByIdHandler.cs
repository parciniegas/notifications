using Dragonfly.Core.Commands;

namespace Notifications.Application.Client.Requests.GetById;

public class GetClientByIdHandler : IHandler<GetClientByIdRequest, ClientResult>
{
    public Task<ClientResult> HandleAsync(GetClientByIdRequest request, CancellationToken cancellationToken = default)
    {
        var client = new ClientResult(1, "Client 1", "Client 1 description");

        return Task.FromResult(client);
    }
}