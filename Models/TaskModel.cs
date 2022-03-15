using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace get_shit_done_webapi.Models
{
    public class TaskModel
    {
        public int Id {get; set;}
        public int ProjectId { get; set; }
        public string? TaskName { get; set; }
        public string? TaskDateCreate { get; set; }
        public string? TaskDescription { get; set; }
        public int PriorityOfTask { get; set; }
        public string? StatusOfTask { get; set; }
        public string? TaskDueDate { get; set; }
        public bool? TaskIsDeleted { get; set; }
        public bool? TaskisArchived { get; set; }
        public TaskModel(){}
    } 
}