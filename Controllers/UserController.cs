using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using get_shit_done_webapi.Models;
using get_shit_done_webapi.Models.DTO;
using get_shit_done_webapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace get_shit_done_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _data;

        public UserController(UserService _dataFromService)
        {
            _data = _dataFromService;
        }
        [HttpGet("GetAllUsers")]
        public IEnumerable<UserModel> GetAllUsers()
        {
            return _data.GetAllUsers();
        }
        [HttpGet("GetUserByUsername/{username}")]
        public UserModel GetUserByUsername(string username)
        {
            return _data.GetUserByUsername(username);
        }

        [HttpPost("AddUser")]
        public bool AddUser(CreateAccountDTO UserToAdd)
        {
            return _data.AddUser(UserToAdd);
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginDTO User)
        {
            return _data.Login(User);
        }

        [HttpPost("UpdateUserModel")]
        public bool UpdateUserModel(UserModel UserToUpdate)
        {
            return _data.UpdateUserModel(UserToUpdate);
        }

        //update the user role from admin to specialist
        //specialist to admin
        [HttpPost("UpdateUserRole/{Username}")]
        public bool UpdateUserRole(string Username)
        {
            return _data.UpdateUserRole(Username);
        }

        [HttpPost("UpdateUser/{id}/{newUsername}")]
        public bool UpdateUser(int id, string newUsername)
        {
            return _data.UpdateUser(id, newUsername);
        }

        [HttpPost("ChangeRevokeUserAccess/{id}")]
        public bool ChangeRevokeUserAccess(int id)
        {
            return _data.ChangeRevokeUserAccess(id);
        }
        [HttpPost("ChangeGiveUserAdminAccess/{id}")]
        public bool ChangeGiveUserAdminAccess(int id)
        {
            return _data.ChangeGiveUserAdminAccess(id);
        }

        [HttpPost("DeleteUser/{userToDelete}")]

        public bool DeleteUser(string userToDelete)
        {
            return _data.DeleteUser(userToDelete);
        
        }

        [HttpPost("ChangeUserOwnerStatusByUserId/{id}")]
        public bool ChangeUserOwnerStatus(int id)
        {
            return _data.ChangeUserOwnerStatus(id);
        }


        

    }
}