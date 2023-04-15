using MediatR;

namespace Notifications.Endpoints.Commands;

public record CreateClientCommand : IRequest<string>
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public CreateClientCommand(string name, string email, string phoneNumber)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
    }
}