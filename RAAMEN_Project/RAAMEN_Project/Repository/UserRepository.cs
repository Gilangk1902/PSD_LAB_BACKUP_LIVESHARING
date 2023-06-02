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
        Database1Entities1 db = DatabaseSingleton.getInstance();

        public void register(int roleId, string username, string email, string gender, string password)
        {
            db.Users.Add(UserFactory.CreateUser(roleId, username, email, gender, password));
            db.SaveChanges();
        }

        public User IsValidCredential(string username, string password)
        {
            User user = db.Users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
            return user;
        }

        public List<User> GetAllUser()
        {
            List<User> users = db.Users.ToList();
            return users;
        }

        public List<User> GetAllCustomer()
        {
            List<User> cust = db.Users.Where(x => x.Roleid == 1).ToList();
            //asumsi bahwa member itu punya Roleid == 1
            return cust;
        }

        public List<User> GetAllStaff()
        {
            List<User> staff = db.Users.Where(x => x.Roleid == 2).ToList();
            //asumsi bahwa member itu punya Roleid == 2
            return staff;
        }

        public User GetUser(int id)
        {
            return db.Users.Find(id);
        }

        public void updateUser(int id, int roleId, string username, string email, string gender,
            string password)
        {
            User user = db.Users.Find(id);
            user.Username = username;
            user.Roleid = roleId;
            user.Email = email;
            user.Gender = gender;
            user.Password = password;
            db.SaveChanges();
        }

        public List<String> getAllRole()
        {
            List<String> roles = (from r in db.Roles select r.name).ToList();
            return roles;
        }

        public Role getRole(int id)
        {
            return db.Roles.Find(id);
        }

        public int getRoleId(String roleListText)
        {
            return (from role in db.Roles where role.name == roleListText select role.id)
            .ToList().FirstOrDefault();
        }

        public void addRole(int id, string name)
        {
            Role role = UserFactory.CreateRole(id, name);
            db.Roles.Add(role);
            db.SaveChanges();
        }

        public void delRole(int id)
        {
            db.Roles.Remove(db.Roles.Find(id));
            db.SaveChanges();
        }

        public void updateRole(int id, string name)
        {
            Role role = db.Roles.Find(id);
            role.name = name;

            db.SaveChanges();
        }

    }
}