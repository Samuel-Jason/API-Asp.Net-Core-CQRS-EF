namespace Todo.Domain.Queries
{
    public static class TodoQueries
    {
        public static Expression<Func<TodoItem, bool>> GetAll(string user)
        {
            return x => x.User == user x.Done == true;
        }

        public static Expression<Func<TodoItem, bool>> GetAll(string user)
        {
            return x => x.User && x.Done == false;
        }

        public static Expression<Func<TodoItem, bool>> GetByPeriod(string user, DateTime = date, bool done)
        {
            return x =>
                x.User == user &&
                x.Done == done &&
                x.Date.Date == date.Date;
        }
    }
}