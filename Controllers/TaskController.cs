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

        [HttpPost("UpdateTaskStatus/{taskId}/{status}")]
        public bool UpdateTaskStatus(int taskId, string? status)
        {
            return _data.UpdateTaskStatus(taskId, status);
        }

        
        [HttpGet("GetTaskByProjectId/{Id}")]
        public IEnumerable<TaskModel> GetTaskByProjectId(int Id)
        {
            return _data.GetTaskByProjectId(Id);
        }

        [HttpGet("GetEverySingleTask")]
        public IEnumerable<TaskModel> GetEverySingleTask()
        {
            return _data.GetEverySingleTask();
        }

        [HttpPost("DeleteTask/{taskId}")]
        public bool DeleteTask(int taskId)
        {
            return _data.DeleteTask(taskId);
        }


        //maybe get a task by status

        [HttpGet("TaskStatus/{TaskStatus}")]
        public IEnumerable<TaskModel> GetTaskByStatus(string TaskStatus)
        {
            return _data.GetTaskByStatus(TaskStatus);
        }

        
    }
}