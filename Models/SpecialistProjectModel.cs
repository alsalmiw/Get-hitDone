using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace get_shit_done_webapi.Models
{
    public class SpecialistProjectModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }

        public SpecialistProjectModel(){}

    }
}