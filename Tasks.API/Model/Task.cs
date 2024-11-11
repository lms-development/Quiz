namespace Tasks.API.Model
{
    public class Task
    {
        public string Name { get; }
        public int Id { get; }

        public bool IsWeekendTask { get; set; }

        public Task(string name, int id, bool wasWeekedTask)
        {
            Name = name;
            Id = id;
            IsWeekendTask = wasWeekedTask;
        }

    }
}