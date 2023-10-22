using Microsoft.AspNetCore.Mvc;
using MinimalApi.Attributes;

namespace Notifications.Api.Clients.Create;


public class CreateClientEndPoint
{ 
    private readonly Random _random = new Random();

    [EndpointPost("/clients")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CreateClientResponse))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IResult> HandleAsync(CreateClientCommand command, CancellationToken cancellationToken = default)
    {
        await Task.Delay(50, cancellationToken);
        if (command.Name == "error")
            return Results.BadRequest("The client name can't be 'error'");
        var client = new CreateClientResponse(_random.Next(1, 1000));
        
        return (client.Id > 500) 
            ? Results.Problem() 
            : Results.Created($"/clients/{client.Id}", client);
    }
}