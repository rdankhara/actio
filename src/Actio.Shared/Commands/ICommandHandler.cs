using System.Threading.Tasks;

namespace Actio.Shared.Commands
{
    public interface ICommandHandler<in T> where T: ICommand
    {
        Task HandleAsync(T command);
    }
    
}