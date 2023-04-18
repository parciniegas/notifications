using Dragonfly.Core.Commands;

namespace Notifications.Application.Client.Requests.GetById;

public class GetClientByIdHandler : IHandler<GetClientByIdRequest, GetClientByIdResult>
{
    public Task<GetClientByIdResult> HandleAsync(GetClientByIdRequest request, CancellationToken cancellationToken = default)
    {
        var result = new GetClientByIdResult(
                true, "NA", "Client found", new Client(1, "Client 1", "Client 1 description"));

        return Task.FromResult(result);
    }
}