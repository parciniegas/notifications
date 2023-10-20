using Dragonfly.CQRS.Commands;

namespace Notifications.Domain.Client.Commands.Create;

public class CreateClientCommandHandler : ICommandHandler<CreateClientCommand, CreateClientResult>
{
    public async Task<CreateClientResult> HandleAsync(CreateClientCommand command, CancellationToken cancellationToken = default)
    {
        var result = new CreateClientResult($"Client {command.Name} created");
        return await Task.FromResult(result);
    }
}