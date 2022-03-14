using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using get_shit_done_webapi.Models;
using get_shit_done_webapi.Services.Context;

namespace get_shit_done_webapi.Services
{
    public class ProjectService 
    {
        private readonly DataContext _context;
        public ProjectService(DataContext context)
        {
            _context = context;
        }

        public bool CreateProject(ProjectModel newProject)
        {
            _context.Add(newBlogItem);
          return _context.SaveChanges() != 0;
        }

        public bool EditProject(ProjectModel ProjectUpdate)
        {
            
        }
        public bool ArchiveProject()
        {
            
        }
        public IEnumerable<ProjectModel> GetAllProjects()
        {
            return _context.ProjectInfo;
        }


    }
}