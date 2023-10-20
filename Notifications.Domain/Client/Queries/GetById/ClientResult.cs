using Dragonfly.CQRS.Queries;

namespace Notifications.Domain.Client.Queries.GetById;

public class ClientResult : QueryResult<string>
{
    public ClientResult(string result) : base(result)
    {
    }
}