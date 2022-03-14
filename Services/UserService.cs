using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using get_shit_done_webapi.Models;
using get_shit_done_webapi.Services.Context;
namespace get_shit_done_webapi.Services
{
    public class UserService
    {
        private readonly DataContext _context;
        public UserService(DataContext context)
        {
            _context = context;
        }

        //Add a user
        // public bool AddUser(CreateAccountDTO UserToAdd)
        // {
            
        // }
    }
}