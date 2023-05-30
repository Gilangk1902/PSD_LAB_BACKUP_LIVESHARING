using RAAMEN_Project.Factory;
using RAAMEN_Project.Handler;
using RAAMEN_Project.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RAAMEN_Project.Controllers
{
    public class RamenController
    {
        private static RamenHandler ramenHandler = new RamenHandler();
        
        public static void Add(int id, int meatId, string name, string broth, string price)
        {
            ramenHandler.Add(RamenFactory.CreateRamen(id,meatId, name, broth, price));
        }

        public static void Delete(int id)
        {
            ramenHandler.Delete(id);
        }

        public static void Update(int targetId, int id, int meatId, string name, string broth, string price)
        {
            ramenHandler.Update(targetId, RamenFactory.CreateRamen(id, meatId, name, broth, price));
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