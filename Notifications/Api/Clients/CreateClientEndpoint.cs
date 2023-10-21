using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinimalApi.Endpoint;

namespace Notifications.Api.Clients;

public class CreateClientEndpoint : IEndpoint<IResult, CreateClientDto>
{
    public void AddRoute(IEndpointRouteBuilder app)
    {
        app.MapPost("/clients", (CreateClientDto request) => HandleAsync(request))
            .Produces<int>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .Produces(StatusCodes.Status500InternalServerError);
    }

    public Task<IResult> HandleAsync(CreateClientDto request)
    {
        var client = new
        {
            Id = new Random().Next(1, 100),
            Name = request.Name,
            Description = request.Description
        };

        return Task.FromResult(Results.CreatedAtRoute($"/api/Client/{client.Id}", client.Id));
    }
}