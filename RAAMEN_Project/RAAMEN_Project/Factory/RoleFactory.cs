using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Model;

namespace RAAMEN_Project.Factory
{
    public class RoleFactory
    {
        public static Role CreateRole(int id, string name)
        {
            Role role = new Role();
            role.id = id;
            role.name = name;

            return role;
        }

    }

}