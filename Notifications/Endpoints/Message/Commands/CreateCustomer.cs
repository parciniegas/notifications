using MediatR;

namespace Notifications.MediatR.Commands
{
    public record CreateCustomerCommand(string Name) : IRequest<CreateCustomerResult>;

    public record CreateCustomerResult(string Name);
}