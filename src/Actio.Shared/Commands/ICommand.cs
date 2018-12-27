namespace Actio.Shared.Commands
{
    public interface ICommand<T> {

        void Execute(T args);
    }

    public interface ICommand {
        //void Execute(object args);
    }
}