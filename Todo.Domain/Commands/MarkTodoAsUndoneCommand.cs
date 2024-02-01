using System;

namespace Todo.Domain.Commands
{
    public Class MarkTodoAsUnDoneCommand : Notifiable, ICommand
	{
    
    public MarkTodoAsUnDoneCommand() { }

    public MarkTodoAsUnDoneCommand(Guid id, string user)
    {
        Id = id;
        User = user;
    }

    public Guid Id { get; set; }
    public string User { get; set; }

    public void Validate()
    {
        AddNotifications(
          new Contract()
            .Require()
            .HasnMinLen(User, 6, "User", "Usuario invalido.")
        );
    }
}
