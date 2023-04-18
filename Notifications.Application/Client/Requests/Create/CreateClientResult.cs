using Dragonfly.Core.Commands;

namespace Notifications.Application.Client.Requests.Create;

public record CreateClientResult : Result<string>
{
    public CreateClientResult(bool succes, string code, string message, string value)
        : base(succes, code, message, value)
    {
    }
}