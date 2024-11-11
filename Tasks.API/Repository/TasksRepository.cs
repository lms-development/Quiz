namespace Tasks.API.Repository
{

    public class TasksRepository
    {
        private static readonly List<Model.Task> Tasks = new();

        public void Add(Model.Task value) 
            => Tasks.Add(value);

        public Model.Task? GetTask(int id)
        {
            var task = Tasks.Find(w => w.Id == id);
            return task;
        }

        public List<Model.Task> GetTasks() 
            => Tasks;
    }
}