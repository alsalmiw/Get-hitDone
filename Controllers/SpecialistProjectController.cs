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
    public class SpecialistProjectController : ControllerBase
    {
        private readonly SpecialistProjectService _data;
        public SpecialistProjectController(SpecialistProjectService _dataFromService)
        {
            _data = _dataFromService;
        }

     

        [HttpPost("AssignSpecialistProject")]
        public bool AddProjectSpecialist(SpecialistProjectModel ProjectToAdd)
        {
            return _data.AddProjectSpecialist(ProjectToAdd);
        }
        
        [HttpGet("GetAllProjectsFromSpecialistId/{UserId}")]
        public List<ProjectModel> GetAllProjectsFromSpeciaListId(int UserId)
        {
            return _data.GetAllProjectsFromSpeciaListId(UserId);
        }
    }
}