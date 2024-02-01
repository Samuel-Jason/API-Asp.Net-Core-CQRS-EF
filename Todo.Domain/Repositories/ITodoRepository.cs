using System;

namespace Todo.Domain.Repositories
{
    public interface ITodoRepository
    {
        void Create (TodoItem todo);
        void Update (TodoItem todo);
    }
}