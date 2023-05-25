using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Model;
using RAAMEN_Project.Factory;

namespace RAAMEN_Project.Repository
{
    public class Role
    {
        Database1Entities1 db = Database.getInstance();

        public List<Role> getAllRole()
        {
            List<Role> roles = db.Roles.ToList();
            return roles;
        }

        public Role getRole(int id)
        {
            return db.Roles.Find(id);
        }

        public void addRole(int id, string name)
        {
            Role role = RoleFactory.CreateRole(id, name);
            db.Roles.Add(role);
            db.SaveChanges();
        }

        public void delRole(int id)
        {
            db.Roles.Remove(db.Roles.Find(id));
            db.SaveChanges();
        }

        public void updateRamen(int id, string name)
        {
            Role role = db.Roles.Find(id);
            role.name = name;

            db.SaveChanges();
        }

    }
}