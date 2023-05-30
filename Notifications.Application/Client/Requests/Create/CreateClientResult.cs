using Dragonfly.Core.Commands;

namespace Notifications.Application.Client.Requests.Create;

public record CreateClientResult : CommandResult<string>
{
    public CreateClientResult(bool success, string message, string value)
        : base(success, message, value)
    {
    }
}