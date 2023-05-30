using Dragonfly.Core.Commands;

namespace Notifications.Application.Client.Requests.Create;

public class CreateClientCommandHandler : ICommandHandler<CreateClientCommand, CreateClientResult>
{
    public Task<CreateClientResult> HandleAsync(CreateClientCommand request, CancellationToken cancellationToken = default)
    {
        var result = new CreateClientResult(true, $"Client {request.Name} created", $"{request.Description}");
        return Task.FromResult(result);
    }
}