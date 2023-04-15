using MediatR;
using Notifications.Endpoints.Client.Commands;

namespace Notifications.Endpoints.Client;

public static class Read
{
    public static async Task<IResult> GetById(IMediator mediator, GetClientQuery command)
    {
        var result = await mediator.Send(command);

        return Results.Ok(result);
    }
}