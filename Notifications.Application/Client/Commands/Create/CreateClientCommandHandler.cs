using Dragonfly.Cqrs.Commands;
using Dragonfly.Domain.Contracts;

namespace Notifications.Application.Client.Requests.Create;

public class CreateClientCommandHandler : ICommandHandler<CreateClientCommand, CreateClientResult>
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateClientCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Task<CreateClientResult> HandleAsync(CreateClientCommand command, CancellationToken cancellationToken = default)
    {
        var result = new CreateClientResult($"Client {command.Name} created");
        return Task.FromResult(result);
    }
}