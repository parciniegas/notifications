using Dragonfly.Core.Commands;

namespace Notifications.Application.Client.Requests.Create;

public record CreateClientRequest(string Name, string Description)
    : IRequest
{
}