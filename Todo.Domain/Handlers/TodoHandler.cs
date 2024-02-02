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

        public ICommandResult Handle(CreateTodoCommand command)
        {
            //fail fast validation
            command.Validate();

            if (command.Invalid)
               Return new GenericCommandResult(false, "Ops erro", command.Notifications);

            //Gera o Todo
            var todo = new TodoItem(command.Title, command.User, command.Date);

            //Salva no banco
            _repository.Create(todo);

            //Retorna o Resultado
            return new GenericCommandResult(true, "Tarefa Salva", command.Date);
        }
    }
}