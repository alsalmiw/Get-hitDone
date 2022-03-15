using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using get_shit_done_webapi.Models;
using get_shit_done_webapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace get_shit_done_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly TaskService _data;

        public TaskController(TaskService _dataFromService)
        {
            _data = _dataFromService;
        }

        [HttpPost("CreateTask")]
        public bool CreateTask(TaskModel newTask)
        {
            return _data.CreateTask(newTask);
        }

        [HttpPost("UpdateTask")]
        public bool UpdateTask(TaskModel TaskUpdate)
        {
            return _data.UpdateTask(TaskUpdate);
        }

        [HttpGet("GetAllTasks")]
        public IEnumerable<TaskModel> GetAllTasks()
        {
            return _data.GetAllTasks();
        }

        [HttpPost("DeleteTask")]
        public bool DeleteTask(TaskModel TaskDelete)
        {
            return _data.DeleteTask(TaskDelete);
        }


        //maybe get a task by status

        [HttpGet("TaskStatus")]
        public bool TaskStatus(TaskModel TaskStatus)
        {
            return _data.TaskStatus(TaskStatus);
        }
        // [HttpGet("GetTaskById/{}")]

        
    }
}