using System;

namespace Todo.Domain.Handler.contracts
{

    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
