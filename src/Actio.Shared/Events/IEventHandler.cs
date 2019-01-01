using System.Threading.Tasks;

namespace Actio.Shared.Events
{
    public interface IEventHandler<in T>  where T: IEvent
    {
        Task HandleAsync(T @event);
    }
}