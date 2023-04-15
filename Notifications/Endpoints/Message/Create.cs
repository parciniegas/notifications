using MediatR;
using Notifications.MediatR.Commands;

namespace Notifications.Endpoints.Message;

public static class Create
{
    public static async Task<IResult> Post(IMediator mediator, CreateCustomerCommand command)
    {
        var customer = await mediator.Send(command);
        return Results.Ok(customer);
    }
}