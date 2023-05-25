using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Model;

namespace RAAMEN_Project.Factory
{
    public class UserFactory
    {
        public static User CreateUser(int id, int roleId, string username, string email, string gender,
            string password)
        {
            User user = new User();
            user.Id = id;
            user.Roleid = roleId;
            user.Username = username;
            user.Email = email;
            user.Gender = gender;
            user.Password = password;

            return user;
        }

    }

}