using Dragonfly.Core.Commands;

namespace Notifications.Application.Client.Requests.Create;

public class CreateClientHandler : IHandler<CreateClientRequest, CreateClientResult>
{
    public Task<CreateClientResult> HandleAsync(CreateClientRequest request, CancellationToken cancellationToken = default)
    {
        var result = new CreateClientResult(true, "OK", $"Client {request.Name} created", $"{request.Description}");
        return Task.FromResult(result);
    }
}