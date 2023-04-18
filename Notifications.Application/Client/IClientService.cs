using Notifications.Application.Client.Requests.Create;
using Notifications.Application.Client.Requests.GetById;

namespace Notifications.Application.Client;

public interface IClientService
{
    Task<CreateClientResult> Create(CreateClientRequest request);

    Task<GetClientByIdResult> GetById(GetClientByIdRequest request);
}