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

        [HttpPost("EditProject")]
        public bool EditProject(ProjectModel ProjectUpdate)
        {
            return _data.EditProject(ProjectUpdate);
        }

        [HttpPost("ArchiveProject")]
        public bool ArchiveProject(ProjectModel ProjectArchive)
        {
            return _data.ArchiveProject(ProjectArchive);
        }
        
        
        [HttpGet("GetAllProjects")]
        public IEnumerable<ProjectModel> GetAllProjects()
        {
            return _data.GetAllProjects();
        }
        
        //Endpoints we need
        //User can create a project
        //User edit a project
        //User can archieve a project
        //Get all the projects
    }
}