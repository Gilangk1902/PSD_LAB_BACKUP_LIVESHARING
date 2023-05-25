using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Model;
using RAAMEN_Project.Factory;

namespace RAAMEN_Project.Repository
{
    public class UserRepository
    {
        Database1Entities1 db = Database.getInstance();

        public List<User> GetAllUser()
        {
            List<User> users = db.Users.ToList();
            return users;
        }

        public User GetUser(int id)
        {
            return db.Users.Find(id);
        }

        public void addUser(int id, int roleId, string username, string email, string gender,
            string password)
        {
            User user = UserFactory.CreateUser(id, roleId, username, email, gender, password);
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void updateUser(int id, int roleId, string username, string email, string gender,
            string password)
        {
            User user = db.Users.Find(id);
            user.Username = username;
            user.Email = email;
            user.Gender = gender;
            user.Password = password;
            db.SaveChanges();
        }


    }
}