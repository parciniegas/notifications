using MediatR;

namespace Notifications.Endpoints.Client.Commands
{
    public record GetClientQuery(string Name) : IRequest<string>;
}