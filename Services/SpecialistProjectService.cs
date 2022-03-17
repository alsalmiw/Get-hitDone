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
        

        public List<ProjectModel> GetAllProjectsFromSpeciaListId(int UserId)
        {
            IEnumerable<ProjectModel> allProjects = _context.ProjectInfo;
            var projects = allProjects.ToList();
            IEnumerable<SpecialistProjectModel> specialistProjects = _context.SpecialistProjectInfo;
            var specialistProjectsVar =specialistProjects.ToList();
            List<ProjectModel> allProjectToReturn = new List<ProjectModel>();
            int projectIDValue = 0;
            for(int i = 0; i<specialistProjectsVar.Count; i++)
            {
                if(specialistProjectsVar[i].UserId == UserId)
                {
                projectIDValue = specialistProjectsVar[i].ProjectId;
                allProjectToReturn.Add(projects[projectIDValue]); 

                }
            }
            return allProjectToReturn;


            // for(int i = 0; i< projects.Count; i++)
            // {
            //     for(int j = 0; j < specialistProjectsVar.Count; j++)
            //     {
            //         if(projects[i].Id == specialistProjectsVar[j].ProjectId)
            //         {
            //             matchingId.Add(projects[i].Id);
            //         }
            //     }
            // }
            // List<IEnumerable> projectsOfSpecialist = new List<IEnumerable>;
           // IEnumerable<ProjectModel> projectsOfSpecialist = (IEnumerable<ProjectModel>)allProjectToReturn;// as IEnumerable<ProjectModel>;
            // List<ProjectModel> projectsOfSpecialist = new List<ProjectModel>();
            // for(int x=0; x<matchingId.Count; x++)
            // {
            //     projectsOfSpecialist = _context.ProjectInfo.Where(item => item.Id == matchingId[x]);
            // }
        }

    }
}