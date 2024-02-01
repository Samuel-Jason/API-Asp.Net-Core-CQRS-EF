using System;

namespace Todo.Domain.Commands
{
    public Class MarkTodoAsDoneCommand : Notifiable, ICommand
	{
    
    public MarkTodoAsDoneCommand() { }

    public MarkTodoAsDoneCommand(Guid id, string user)
    {
        Id = id;
        User = user;
    }

    public Guid Id { get; set; }

    public string User MyProperty { get; set; }

    public void Validate()
    {
       AddNotifications(
         new Contract()
           .Require()
           .HasnMinLen(User, 6, "User", "Usuario invalido.")
       );
    }
}
