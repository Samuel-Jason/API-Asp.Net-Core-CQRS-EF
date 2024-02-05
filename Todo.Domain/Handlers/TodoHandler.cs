using System;

namespace Todo.Domain.Handlers
{
    public class TodoHandler : 
        Notifiable,
        IHandler<CreateTodoCommand>,
        IHandler<UpdateTodoCommand>,
        IHandler<MarkTodoAsDoneCommand>,
        IHandler<MarkTodoAsUndoneCommand>
    {
        private readonly ITodoRepository _repository;

        public TodoHandler(ITodoRepository repository)
        {
            _repository = repository
        }

        public ICommandResult Handle(CreateTodoCommand command) { 
        }

        public ICommandResult Handle(UpdateTodoCommand command)
        {
            //fail fast validation
            command.Validate();
            if (command.Invalid)
               Return new GenericCommandResult(false, "Ops erro", command.Notifications);

            var todo = _repository.GetById(command.Id, command.User);

            todo.MarkAsDone();

            //Salva no banco
            _repository.Update(todo);

            //Retorna o Resultado
            return new GenericCommandResult(true, "Tarefa Salva", command.Date);
        }
    }
}