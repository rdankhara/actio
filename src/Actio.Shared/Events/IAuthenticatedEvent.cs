using System;

namespace Actio.Shared.Events
{
    public interface IAuthenticatedEvent : IEvent
    {
        Guid UserId {get;}   
    }
}