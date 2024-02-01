using System;

namespace Todo.Domain.Handlers
{
    public class TodoHandler : 
        Notifiable,
        IHandler<CreateTodoCommand>
    {
        private readonly ITodoRepository _repository;

        public TodoHandler(ITodoRepository repository)
        {
            _repository = repository
        }

        public ICommandResult Handle (CreateTodoCommand command)
        {
            //fail fast validation
            command.Validate();
            if(command.Invalid)
                Return new GenericCommandResult(false, "Ops erro", command.Notifications);
        }
    }
}