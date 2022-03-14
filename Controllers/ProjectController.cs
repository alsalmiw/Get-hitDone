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
    public class ProjectController : ControllerBase
    {
        private readonly ProjectService _data;
        public ProjectController(ProjectService _dataFromService)
        {
            _data = _dataFromService;
        }

        [HttpPost("CreateProject")]
        public bool CreateProject(ProjectModel newProject)
        {
            return _data.CreateProject(newProject);
        }
        
        
        
        
        
        //Endpoints we need
        //User can create a project
        //User edit a project
        //User can archieve a project
        //Get all the projects
    }
}