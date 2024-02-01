using System;
using Flunt.Notifications;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class CreateTodoCommand : Notifiable, ICommand
    {
        public CreateTodoCommand() { }

        public CreateTodoCommand(string title, string user, DateTime date)
        {
            Title = title;
            User = user;
            Date = date;
        }

        public string Title { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Require()
                    .HasMinLen(Title, 3, "Title", "Por Favor, descreva melhor a tarefa!")
                    .HasnMinLen(User, 6, "User", "Usuario invalido.")
                );


            //if (Title.Length < 4)
            //	AddNotification("title", "Titulo Invalido");
            //	return Valid;
        }
    }
}