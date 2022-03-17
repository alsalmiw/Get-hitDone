using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using get_shit_done_webapi.Models;
using get_shit_done_webapi.Services.Context;

namespace get_shit_done_webapi.Services
{
    public class SpecialistProjectService
    {
        private readonly DataContext _context;
        public SpecialistProjectService(DataContext context)
        {
            _context = context;
        }
        public bool AddProjectSpecialist(SpecialistProjectModel ProjectToAdd)
        {
            _context.Add(ProjectToAdd);
            return _context.SaveChanges() != 0;
        }
        

        public IEnumerable<ProjectModel> GetAllProjectsFromSpeciaListId(int UserId)
        {
            IEnumerable<ProjectModel> allProjects = _context.ProjectInfo;
            var projects = allProjects.ToList();
            IEnumerable<SpecialistProjectModel> specialistProjects = _context.SpecialistProjectInfo.Where(user => user.UserId == UserId);
            var specialistProjectsVar =specialistProjects.ToList();
            List<int> matchingId = new List<int>();
            for(int i = 0; i< projects.Count; i++)
            {
                for(int j = 0; j < specialistProjectsVar.Count; j++)
                {
                    if(projects[i].Id == specialistProjectsVar[j].ProjectId)
                    {
                        matchingId.Add(projects[i].Id);
                    }
                }
            }
            // List<IEnumerable> projectsOfSpecialist = new List<IEnumerable>;
            IEnumerable<ProjectModel> projectsOfSpecialist = Enumerable.Empty<ProjectModel>();
            for(int x=0; x<matchingId.Count; x++)
            {
                projectsOfSpecialist.Append(_context.ProjectInfo.Where(item => item.Id == matchingId[x]));
            }
            return projectsOfSpecialist;
        }
        // _context.ProjectInfo.Where(item => item.Id == matchingId);
        // return _context.ProjectInfo.SingleOrDefault(item => item.Id == Id)
            //get list of all projects


        // specialist model
        // Specialist(user) ID
        //  Project ID (list) all projects assign to specialist 


        //list of project = prolist
        // list of project assign to user = 
        
        // public IEnumerable<TaskModel> GetAllTasks()
        // {
        //     return _context.TaskInfo;
        // }
    }
}