using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Model;

namespace RAAMEN_Project.Factory
{
    public class RamenFactory
    {
        public static Ramen CreateRamen( int meatId, string name, string broth, string price)
        {
            Ramen ramen = new Ramen
            {
                Meatid = meatId,
                Name = name,
                Broth = broth,
                Price = price
            };

            return ramen;
        }
        
    }

}