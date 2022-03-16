using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using get_shit_done_webapi.Models;
using get_shit_done_webapi.Models.DTO;
using get_shit_done_webapi.Services.Context;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace get_shit_done_webapi.Services
{
    public class UserService : ControllerBase
    {
        private readonly DataContext _context;
        public UserService(DataContext context)
        {
            _context = context;
        }

        public UserModel GetUserByID(int Id)
        {
            return _context.UserInfo.SingleOrDefault(user => user.Id == Id);
        }

        public UserModel GetUserByUsername(string username)
        {
            return _context.UserInfo.SingleOrDefault(user => user.Username == username);
        }

        public bool UpdateUser(int id, string newUsername)
        {
            UserModel foundUser = GetUserByID(id);
            bool result = false;
            if(foundUser != null)
            {
                foundUser.Username = newUsername;
                _context.Update<UserModel>(foundUser);
                result = _context.SaveChanges() != 0;
            }
            return result;
        }

        public bool UpdateUserModel(UserModel UserToUpdate)
        {
            _context.Update<UserModel>(UserToUpdate);
            return _context.SaveChanges() !=0;
        }

        public bool DeleteUser(string Username)
        {
            UserModel foundUser = GetUserByUsername(Username);
            bool result = false;
            if(foundUser != null)
            {
                foundUser.Username = Username;
                _context.Remove<UserModel>(foundUser);
               result =  _context.SaveChanges() != 0;
            }
            return result;
        }

        public bool DoesUserExists(string? username)
        {
            return _context.UserInfo.SingleOrDefault(user => user.Username == username) != null;
        }
        public bool revokedStatus(string? username)
        {
            bool result = false;
            UserModel foundUser = GetUserByUsername(username);
            if(foundUser.isRevoked == true)
            {
                result = true;
            }
            return result; 
        }
        public IActionResult Login(LoginDTO user)
        {
            IActionResult Result = Unauthorized();
            if(DoesUserExists(user.Username))
            {
                var foundUser = GetUserByUsername(user.Username);
                var verifyPass = VerifyUserPassword(user.Password, foundUser.Hash, foundUser.Salt);
                var isRevoked = revokedStatus(user.Username);
                if(verifyPass)
                {
                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ILoveToTaskTrackerAllDay@209"));
                    var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                    var tokeOptions = new JwtSecurityToken(
                        issuer: "http://localhost:5000",
                        audience: "http://localhost:5000",
                        claims: new List<Claim>(),
                        expires: DateTime.Now.AddMinutes(30),
                        signingCredentials: signinCredentials
                    );              
                    if(isRevoked == false)
                    {
                        var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                        Result = Ok(new { Token = tokenString });
                    }
                }
            }
            return Result;

        }



         public PasswordDTO HashPassword(string? password)
        {
            PasswordDTO newHashedPassword = new PasswordDTO();
            byte[] SaltBytes = new byte[64];
            var provider = RandomNumberGenerator.Create();
            provider.GetNonZeroBytes(SaltBytes);
            var Salt = Convert.ToBase64String(SaltBytes);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, SaltBytes, 10000);
            var HashPassword = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));
            newHashedPassword.Salt = Salt;
            newHashedPassword.Hash = HashPassword;
            return newHashedPassword;
        }

        public bool VerifyUserPassword(string? Password, string? StoredHash, string? StoredSalt)
        {
            var SaltBytes = Convert.FromBase64String(StoredSalt);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(Password, SaltBytes, 10000);
            var newHash = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));
            return newHash == StoredHash;
        }


         public bool AddUser(CreateAccountDTO UserToAdd)
        {
            bool result = false;
            if (!DoesUserExists(UserToAdd.Username))
            {
                UserModel newUser = new UserModel();
				newUser.Id = 0; 
                newUser.Username = UserToAdd.Username;
                
                var hashedPassword = HashPassword(UserToAdd.Password);
             
                newUser.Salt = hashedPassword.Salt;
                newUser.Hash = hashedPassword.Hash;
                newUser.isAdmin = false;
                newUser.isOwner = false;
                newUser.isRevoked = false;
                newUser.isDeleted = false;
							
                _context.Add(newUser);

                result = _context.SaveChanges() != 0;   
            }
            return result;
        }

    }
}