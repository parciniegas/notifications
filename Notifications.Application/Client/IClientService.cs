using Notifications.Application.Client.Queries.GetById;
using Notifications.Application.Client.Requests.Create;

namespace Notifications.Application.Client;

public interface IClientService
{
    Task<CreateClientResult> CreateClient(CreateClientCommand command);

    Task<ClientResult> GetClientById(GetClientByIdQuery query);
}