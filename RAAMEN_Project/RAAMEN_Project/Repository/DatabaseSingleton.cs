using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Model;

namespace RAAMEN_Project.Repository
{
    public class DatabaseSingleton
    {
        private static Database1Entities1 db = new Database1Entities1();

        public static Database1Entities1 getInstance()
        {
            return db;
        }
    }
}