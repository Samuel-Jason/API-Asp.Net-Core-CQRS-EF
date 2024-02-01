using System;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
	public class CreateTodoCommand : ICommand
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

		public List<string> Errors { get; set; }

		public void Validate()
		{
			if (Title.Length < 4)
			{
				Errors.Add("Titulo Invalido");
			}

			if (User.Length < 4)
			{
				Errors.Add("Usuario Invalido");
			}
		}
	}
}