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
        
        // public IEnumerable<ProjectModel> GetAllProjectsFromSpeciaListId(int id)
        // {
        //     return 
        // }

        // public List<SpecialistProjectModel> GetProjectsById(int Userid)
        // {
            
        // }
        // specialist model
        // Specialist(user) ID
        //  Project ID (list) all projects assign to specialist 
    }
}