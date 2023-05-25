using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Model;

namespace RAAMEN_Project.Factory
{
    public class RamenFactory
    {
        public static Ramen CreateRamen(int id, int meatId, string name, string broth, string price)
        {
            Ramen ramen = new Ramen();
            ramen.id = id;
            ramen.Meatid = meatId;
            ramen.Name = name;
            ramen.Broth = broth;
            ramen.Price = price;

            return ramen;
        }
        
    }

}