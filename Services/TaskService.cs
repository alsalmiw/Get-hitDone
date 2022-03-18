using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using get_shit_done_webapi.Models;
using get_shit_done_webapi.Services.Context;

namespace get_shit_done_webapi.Services
{
    public class TaskService
    {
        private readonly DataContext _context;
        public TaskService(DataContext context)
        {
            _context = context;
        }

        public bool CreateTask(TaskModel newTask)
        {
            _context.Add(newTask);
            return _context.SaveChanges() != 0;
        }

        public bool UpdateTask(TaskModel TaskUpdate)
        {
            _context.Update<TaskModel>(TaskUpdate);
            return _context.SaveChanges() != 0;
        }

        public bool UpdateTaskStatus(int taskId, string? status)
        {
			TaskModel foundTask = GetTaskById(taskId);
            bool result = false;
            if(foundTask != null)
            {
                foundTask.StatusOfTask = status;
                _context.Update<TaskModel>(foundTask);
               result =  _context.SaveChanges() != 0;
            }
            return result;
        }

        public IEnumerable<TaskModel> GetAllTasks()
        {
            return _context.TaskInfo;
        }

        public bool DeleteTask(TaskModel TaskDelete)
        {
            TaskDelete.TaskIsDeleted = true;
            _context.Update<TaskModel>(TaskDelete);
            return _context.SaveChanges() !=0;
        }
        public TaskModel GetTaskById(int Id)
        {
            return _context.TaskInfo.SingleOrDefault(item => item.Id == Id);
        }

        public IEnumerable<TaskModel> GetTaskByStatus (string TaskStatus)
        {
            return _context.TaskInfo.Where(item => item.StatusOfTask == TaskStatus);
        }
        public IEnumerable<TaskModel> GetTaskByProjectId(int Id)
        {
            return _context.TaskInfo.Where(item => item.ProjectId == Id);
        }
        public IEnumerable<TaskModel> GetEverySingleTask()
        {
            return _context.TaskInfo;
        }
    
    }
}