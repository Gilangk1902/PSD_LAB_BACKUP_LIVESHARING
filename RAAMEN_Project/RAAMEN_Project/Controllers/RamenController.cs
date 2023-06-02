using RAAMEN_Project.Factory;
using RAAMEN_Project.Handler;
using RAAMEN_Project.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.WebPages;
using System.Xml.Linq;

namespace RAAMEN_Project.Controllers
{
    public class RamenController
    {
        private static RamenHandler ramenHandler = new RamenHandler();
        
        public static void Add(int meatId, string name, string broth, string price)
        {
            if (Validate(meatId, name, broth, price))
            {
                ramenHandler.Add(RamenFactory.CreateRamen(meatId, name, broth, price));
            }
        }

        private static bool Validate(int meatId, string name, string broth, string price)
        {
            int price_in_integer = int.Parse(price);
            if (!name.Contains("Ramen") || meatId == 0 || broth.IsEmpty() || price_in_integer < 3000)
            {
                return false;
            }
            return true;
        }

        public static string SetErrorMsg(int meatId, string name, string broth, string price)
        {
            if (!name.Contains("Ramen"))
            {
                return "Ramen name must contain the word 'Ramen'";
            }
            else if (broth.IsEmpty())
            {
                return "Broth must be filled";
            }
            else if (int.Parse(price) < 3000)
            {
                return "Price must be at least 3000";
            }
            return "";
        }

        public static void Delete(int id)
        {
            ramenHandler.Delete(id);
        }

        public static void Update(int targetId, int meatId, string name, string broth, string price)
        {
            ramenHandler.Update(targetId, RamenFactory.CreateRamen(meatId, name, broth, price));
        }

        public static Ramen Get(int id)
        {
            return ramenHandler.Get(id);
        }

        public static List<Ramen> GetAll()
        {
            return ramenHandler.GetAll();
        }
    }
}