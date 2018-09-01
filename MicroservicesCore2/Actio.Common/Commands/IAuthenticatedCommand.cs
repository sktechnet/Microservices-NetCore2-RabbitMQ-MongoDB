using System;

namespace Actio.Common.Commands
{
    public interface IAuthenticatedEvent:IEvent
    {
        Guid UserId { get; set; }
    }
}