using MinimalApi.Attributes;

namespace Notifications.Api.Clients.Get;

public class GetClientEndpoint
{
    [EndpointGet("/clients")]
    public async Task<IResult> GetAll()
    {
        await Task.Delay(10);
        return Results.Ok(new List<ClientDto>());
    }
    
    [EndpointGet("/clients/{id}")]
    public async Task<IResult> GetById(int id)
    {
        await Task.Delay(10);
        return Results.Ok(new ClientDto(id, "Test"));
    }
}