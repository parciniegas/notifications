using Dragonfly.Cqrs.Commands;

namespace Notifications.Application.Client.Requests.Create;

public record CreateClientCommand(string Name, string Description)
    : ICommand
{
}