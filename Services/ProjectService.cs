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
            _context.Add(newProject);
            return _context.SaveChanges() != 0;
        }

        public bool UpdateProject(ProjectModel ProjectUpdate)
        {
            _context.Update<ProjectModel>(ProjectUpdate);
            return _context.SaveChanges() !=0;

        }

        public bool UpdateProjectStatus(int projectId, string? status)
        {
			ProjectModel foundProject = GetProjectById(projectId);
            bool result = false;
            if(foundProject != null)
            {
                foundProject.StatusOfProject = status;
                _context.Update<ProjectModel>(foundProject);
               result =  _context.SaveChanges() != 0;
            }
            return result;
        }
        
        public bool ArchiveProject(int projectId)
        {
            ProjectModel foundProject = GetProjectById(projectId);
            bool result = false;
            if(foundProject != null)
            {
                foundProject.isArchived = true;
                _context.Update<ProjectModel>(foundProject);
                result =  _context.SaveChanges() !=0;
            }
            return result;
        }

        
        public IEnumerable<ProjectModel> GetAllProjects()
        {
            return _context.ProjectInfo;
        }
        public ProjectModel GetProjectById(int Id)
        {
            return _context.ProjectInfo.SingleOrDefault(item => item.Id == Id);
        }
        public IEnumerable<ProjectModel> GetProjectByUserID(int UserId)
        {
            return _context.ProjectInfo.Where(item => item.UserId == UserId);
        }

        public bool DeleteProject(int projectId)
        {
            ProjectModel foundProject = GetProjectById(projectId);
            bool result = false;
            if(foundProject != null)
            {
                foundProject.Id = projectId;
                _context.Remove<ProjectModel>(foundProject);
               result =  _context.SaveChanges() != 0;
            }
            return result;
        }

    }
}