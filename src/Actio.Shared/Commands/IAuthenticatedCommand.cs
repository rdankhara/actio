using System;

namespace Actio.Shared.Commands
{
    public interface IAuthenticatedCommand
    {
        Guid UserId {get; set;}
    }
}