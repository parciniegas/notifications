using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notifications.Api.Clients;

public record CreateClientDto(string Name, string Description) { }