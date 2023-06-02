using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Factory;
using RAAMEN_Project.Model;
using RAAMEN_Project.Repository;
using RAAMEN_Project.Handler;

namespace RAAMEN_Project.Controllers
{
    public class TransactionController
    {
        private static TransactionHandler trHandler = new TransactionHandler();

        public static List<Header> getAllHeader()
        {
            return trHandler.GetAll();
        }

        public static List<Header> getAllHeaderById(int id)
        {
            return trHandler.GetAllHeadersById(id);
        }
    }
}