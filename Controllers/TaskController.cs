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
    }
}