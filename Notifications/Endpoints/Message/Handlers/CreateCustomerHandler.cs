using MediatR;
using Notifications.MediatR.Commands;

namespace Notifications.MediatR.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, CreateCustomerResult>
    {
        public Task<CreateCustomerResult> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new CreateCustomerResult(request.Name));
        }
    }
}