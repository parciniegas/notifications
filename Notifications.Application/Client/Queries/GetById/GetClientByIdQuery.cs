using Dragonfly.Cqrs.Queries;

namespace Notifications.Application.Client.Queries.GetById;

public record GetClientByIdQuery(int Id) : IQuery
{ }