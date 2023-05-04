using Dragonfly.Domain;
using Dragonfly.Core.Sequences;

namespace Notifications.Domain.Client.Entities
{
    public class Client : Entity<long>
    {
        public Client(string name, string email, string token, string? description = default)
            : base(TimedId.NewId())
        {
            Name = name;
            Email = email;
            Token = token;
            Description = description;
        }

        public string Name { get; }
        public string Email { get; }
        public string? Description { get; }
        public string Token { get; }
    }
}