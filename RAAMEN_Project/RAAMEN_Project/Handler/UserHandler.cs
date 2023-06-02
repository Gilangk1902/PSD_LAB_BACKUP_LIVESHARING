using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Model;
using RAAMEN_Project.Repository;

namespace RAAMEN_Project.Handler
{
    public class UserHandler
    {
        UserRepository userRepo = new UserRepository();

        public User IsValidCredential(string username, string password)
        {
            return userRepo.IsValidCredential(username, password);
        }
      
        public void register(int roleId, string username, string email, string gender, string password)
        {
            userRepo.register(roleId, username, email, gender, password);
        }

        public User GetUser(int id)
        {
            return userRepo.GetUser(id);
        }
        public List<User> GetAllCustomer()
        {
            return userRepo.GetAllCustomer();
        }

        public Role GetRole(int id)
        {
            return userRepo.getRole(id);
        }
        public void Update(int target_id, User user)
        {
            userRepo.updateUser(target_id, user.Roleid, user.Username,user.Email, user.Gender, user.Password);
        }
    }
}