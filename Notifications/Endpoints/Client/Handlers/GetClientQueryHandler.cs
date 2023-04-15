using MediatR;
using Notifications.Endpoints.Client.Commands;

namespace Notifications.Endpoints.Client.Handlers
{
    public class GetClientQueryHandler : IRequestHandler<GetClientQuery, string>
    {
        public Task<string> Handle(GetClientQuery request, CancellationToken cancellationToken)
        {
            var client = $"Client is {request.Name}";

            return Task.FromResult(client);
        }
    }
}