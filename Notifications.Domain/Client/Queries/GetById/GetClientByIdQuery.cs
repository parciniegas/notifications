using Dragonfly.CQRS.Queries;

namespace Notifications.Domain.Client.Queries.GetById;

public record GetClientByIdQuery(int Id) : IQuery;