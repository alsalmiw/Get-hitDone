using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace get_shit_done_webapi.Models
{
    public class UserModel
    {
        public int Id {get; set;}
        public string? Username {get; set;}
        public string? Salt {get; set;}
        public string? Hash {get; set;}
        public UserModel(){}
    }
}