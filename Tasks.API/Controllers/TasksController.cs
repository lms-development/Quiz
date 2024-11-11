using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Tasks.API.Services;


namespace Tasks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        /// <summary>
        /// Task service
        /// </summary>
        private readonly TasksService _tasksService = new();

        /// <summary>
        /// Action to get all Tasks
        /// </summary>
        /// <returns>List<Task></Task></returns>
        [HttpGet]
        public IActionResult Get() => _tasksService.GetTasks();

        /// <summary>
        /// Get an individual Task by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Task</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id) => _tasksService.GetTask(id);

        /// <summary>
        /// Create a new task
        /// </summary>
        /// <param name="task"></param>
        /// <returns>201</returns>
        [HttpPost]
        public IActionResult Post(Model.Task task)
        {
            _tasksService.CreateTask(task);
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
