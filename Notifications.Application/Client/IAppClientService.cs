using Notifications.Domain.Client.Commands.Create;
using Notifications.Domain.Client.Queries.GetById;

namespace Notifications.Application.Client;

public interface IAppClientService
{
    Task<CreateClientResult> CreateClient(CreateClientCommand command);

    Task<ClientResult> GetClientById(GetClientByIdQuery query);
}