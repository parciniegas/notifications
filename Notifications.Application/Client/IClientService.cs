using Notifications.Application.Client.Requests.Create;
using Notifications.Application.Client.Requests.GetById;

namespace Notifications.Application.Client;

public interface IClientService
{
    Task<CreateClientResult> CreateClient(CreateClientCommand request);

    Task<ClientResult> GetClientById(GetClientByIdRequest request);
}