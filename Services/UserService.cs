using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using get_shit_done_webapi.Models;
using get_shit_done_webapi.Models.DTO;
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

        public bool DoesUserExists(string? username)
        {
            return _context.UserInfo.SingleOrDefault(user => user.Username == username) != null;
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


         public bool AddUser(CreateAccountDTO UserToAdd)
        {
             bool result = false;
            if (!DoesUserExists(UserToAdd.Username))
            {
                UserModel newUser = new UserModel();
								newUser.Id = UserToAdd.Id; 
                newUser.Username = UserToAdd.Username;
                
                var hashedPassword = HashPassword(UserToAdd.Password);
             
                newUser.Salt = hashedPassword.Salt;
                newUser.Hash = hashedPassword.Hash;
							
                _context.Add(newUser);

                result = _context.SaveChanges() != 0;   
            }
            return result;
        }

    }
}