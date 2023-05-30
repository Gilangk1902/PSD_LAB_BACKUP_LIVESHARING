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
    public class MeatController
    {
        private static MeatHandler meatHandler = new MeatHandler();
        public static void Add(int id, string name)
        {
            meatHandler.Add(MeatFactory.Create(id, name));
        }
        public static void Delete(int id)
        {
            meatHandler.Delete(id);
        }
        public static void Update(int targetId ,int newId, string newName)
        {
            meatHandler.Update(targetId, MeatFactory.Create(newId, newName));
        }
        public static Meat Get(int id)
        {
            return meatHandler.Get(id);
        }
        public static List<Meat> GetAll()
        {
            return meatHandler.GetAll();
        }
    }
}