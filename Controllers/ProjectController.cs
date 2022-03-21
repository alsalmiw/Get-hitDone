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

        [HttpPost("UpdateProject")]
        public bool UpdateProject(ProjectModel ProjectUpdate)
        {
            return _data.UpdateProject(ProjectUpdate);
        }

        [HttpPost("UpdateProjectStatus/{projectId}/{status}")]
        public bool UpdateProjectStatus(int projectId, string? status)
        {
            return _data.UpdateProjectStatus(projectId, status);
        }

        [HttpPost("ArchiveProject/{projectId}")]
        public bool ArchiveProject(int projectId)
        {
            return _data.ArchiveProject(projectId);
        }

       
        [HttpGet("GetAllProjects")]
        public IEnumerable<ProjectModel> GetAllProjects()
        {
            return _data.GetAllProjects();
        }

        [HttpGet("GetProjectById/{Id}")]
        public ProjectModel GetProjectById(int Id)
        {
            return _data.GetProjectById(Id);
        }

        [HttpGet("GetProjectByUserID/{userId}")]
        public IEnumerable<ProjectModel> GetProjectByUserID(int UserId)
        {
            return _data.GetProjectByUserID(UserId);
        }

        [HttpPost("DeleteProject/{projectId}")]

        public bool DeleteProject(int projectId)
        {
            return _data.DeleteProject(projectId);
        }





        
        
        //Endpoints we need
        //User can create a project
        //User edit a project
        //User can archieve a project
        //soft delete a project
        //Get all the projects

    }
}