using Dragonfly.Cqrs.Commands;

namespace Notifications.Application.Client.Requests.Create;

public class CreateClientCommandHandler : ICommandHandler<CreateClientCommand, CreateClientResult>
{
    public Task<CreateClientResult> HandleAsync(CreateClientCommand command, CancellationToken cancellationToken = default)
    {
        var result = new CreateClientResult($"Client {command.Name} created");
        return Task.FromResult(result);
    }
}