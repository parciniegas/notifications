using Dragonfly.Core.Commands;

namespace Notifications.Application.Client.Requests.GetById;

public record GetClientByIdRequest(int Id) : ICommand
{ }