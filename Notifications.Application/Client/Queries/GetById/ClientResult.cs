using Dragonfly.Cqrs.Queries;

namespace Notifications.Application.Client.Queries.GetById;

public class ClientResult : QueryResult<string>
{
    public ClientResult(string result) : base(result)
    {
    }
}