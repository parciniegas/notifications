using MediatR;
using Notifications.Endpoints.Commands;

namespace Notifications.Endpoints.Handlers;

public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, string>
{
    public Task<string> Handle(CreateClientCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult($"Client {request.Name} created");
    }
}