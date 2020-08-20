using ExchangeContextShared.Commands;

namespace ExchangeContextShared.Handles
{
    public interface IHandle<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
