using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Model;

namespace RAAMEN_Project.Factory
{
    public class UserFactory
    {
        //USER
        public static User CreateUser(int roleId, string username, string email, string gender,
            string password)
        {
            User user = new User();
            user.Roleid = roleId;
            user.Username = username;
            user.Email = email;
            user.Gender = gender;
            user.Password = password;

            return user;
        }

        //ROLE
        public static Role CreateRole(int id, string name)
        {
            Role role = new Role();
            role.id = id;
            role.name = name;

            return role;
        }
    }

}