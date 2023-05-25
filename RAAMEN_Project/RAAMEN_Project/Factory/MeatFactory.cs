using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Model;

namespace RAAMEN_Project.Factory
{
    public class MeatFactory
    {
        public static Meat Create(int id, string name)
        {
            return new Meat()
            {
                id = id,
                name = name,
            };
        }
    }

}