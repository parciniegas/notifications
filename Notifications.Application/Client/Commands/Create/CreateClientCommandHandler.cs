using Dragonfly.Cqrs.Commands;

namespace Notifications.Application.Client.Requests.Create;

public class CreateClientCommandHandler : ICommandHandler<CreateClientCommand, CreateClientResult>
{
    public Task<CreateClientResult> HandleAsync(CreateClientCommand command, CancellationToken cancellationToken = default)
    {
        var result = new CreateClientResult(true, $"Client {command.Name} created", $"{command.Description}");
        return Task.FromResult(result);
    }
}