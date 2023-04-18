using Dragonfly.Core.Commands;

namespace Notifications.Application.Client.Requests.GetById
{
    public record GetClientByIdResult : Result<Client>
    {
        public GetClientByIdResult(bool succes, string code, string message, Client value) : base(succes, code, message, value)
        {
        }
    }
}