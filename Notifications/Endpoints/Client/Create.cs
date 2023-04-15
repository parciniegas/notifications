using Notifications.Endpoints.Commands;
using MediatR;

namespace Notifications.Endpoints.Client
{
    public static class Create
    {
        public static async Task<IResult> Post(IMediator mediator, CreateClientCommand command)
        {
            var result = await mediator.Send(command);

            return Results.Ok(result);
        }
    }
}