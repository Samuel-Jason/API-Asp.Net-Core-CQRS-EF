using System;

namespace Todo.Domain.Commands
{
    public Class UpdateTodoCommand : Notifiable, ICommand
	{
    
    public UpdateTodoCommand() { }

    public UpdateTodoCommand(Guid id,string title, string user)
    {
        Id = id;
        Title = title;
        User = user;
    }

    public Guid Id { get; set; }
    public string Title { get; set; }
    public string User  { get; set; }

    public void Validate()
    {
        AddNotifications(
          new Contract()
            .Require()
            .HasnMinLen(Title, 6, "Title", "Title invalido.")
            .HasnMinLen(User, 6, "User", "Usuario invalido.")
        );
    }
}
