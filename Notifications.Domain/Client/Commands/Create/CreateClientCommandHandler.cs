using Dragonfly.Cqrs.Commands;

namespace Notifications.Domain.Client.Commands.Create;

public class CreateClientCommandHandler : ICommandHandler<CreateClientCommand, CreateClientResult>
{
    public Task<CreateClientResult> HandleAsync(CreateClientCommand command, CancellationToken cancellationToken = default)
    {
        var id = new Random().Next(1, 100);
        var result = new CreateClientResult(id, command.Name);
        return Task.FromResult(result);
    }
}