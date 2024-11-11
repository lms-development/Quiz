using Microsoft.AspNetCore.Mvc;
using Tasks.API.Repository;

namespace Tasks.API.Services;

public class TasksService
{
    private readonly TasksRepository _tasksRepository = new();

    public IActionResult GetTask(int id)
    {
        var task = _tasksRepository.GetTask(id);
        return new OkObjectResult(task);
    }

    public void CreateTask(Model.Task value)
    {
        switch (DateTime.Now.DayOfWeek)
        {
            case DayOfWeek.Saturday:
            case DayOfWeek.Sunday:
                value.IsWeekendTask = true;
                break;
            case DayOfWeek.Monday:
                break;
            case DayOfWeek.Tuesday:
                break;
            case DayOfWeek.Wednesday:
                break;
            case DayOfWeek.Thursday:
                break;
            case DayOfWeek.Friday:
                break;
            default:
                value.IsWeekendTask = false;
                break;
        }

        _tasksRepository.Add(value);
    }

    public IActionResult GetTasks()
    {
        var tasks = _tasksRepository.GetTasks();
        return new OkObjectResult(tasks);
    }
}