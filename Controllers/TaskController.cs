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

        //
        [HttpGet("GetAllTasksWithProjectId/{Id}")]
        public IEnumerable<TaskModel> GetAllTasks(int Id)
        {
            return _data.GetAllTasks();
        }

        [HttpPost("DeleteTask")]
        public bool DeleteTask(TaskModel TaskDelete)
        {
            return _data.DeleteTask(TaskDelete);
        }


        //maybe get a task by status

        [HttpGet("TaskStatus/{TaskStatus}")]
        public IEnumerable<TaskModel> GetTaskByStatus(string TaskStatus)
        {
            return _data.GetTaskByStatus(TaskStatus);
        }

        
    }
}