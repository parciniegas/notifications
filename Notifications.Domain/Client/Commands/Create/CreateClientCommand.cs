﻿using Dragonfly.Cqrs.Commands;

namespace Notifications.Domain.Client.Commands.Create;

public record CreateClientCommand(string Name, string Description) : ICommand;