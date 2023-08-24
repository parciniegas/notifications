using Dragonfly.Domain.Services;
using Notifications.Domain.Client.Commands.Create;
using Notifications.Domain.Client.Queries.GetById;

namespace Notifications.Domain.Client;

public interface IDomainClientService: IDomainService
{
    Task<CreateClientResult> CreateClient(CreateClientCommand command);

    Task<ClientResult> GetClientById(GetClientByIdQuery query);
}
