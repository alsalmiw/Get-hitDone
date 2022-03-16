using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace get_shit_done_webapi.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? ProjectName { get; set; }
        public string? ProjectDescription { get; set; }
        public string? DateCreate { get; set; }
        public string? DueDate { get; set; }
        public string? StatusOfProject { get; set; }
        public int PriorityOfProject { get; set; }
        public bool isDeleted { get; set; }
        public bool isArchived { get; set; }
        public ProjectModel(){ }
    }
}