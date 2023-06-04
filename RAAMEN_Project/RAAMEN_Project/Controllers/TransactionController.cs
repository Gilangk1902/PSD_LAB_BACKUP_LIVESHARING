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

        public static void AddHeader(int id, int customer_id, int staff_id, DateTime date)
        {
            trHandler.AddHeader(TransactionFactory.CreateHeader(id, customer_id, staff_id, date));
        }
        public static void AddDetail(int header_id, int ramen_id, int quantity)
        {
            trHandler.AddDetail(TransactionFactory.CreateDetail(header_id, ramen_id, quantity));
        }

        public static List<Header> getAllHeader()
        {
            return trHandler.GetAll();
        }

        public static List<Header> getAllHeaderById(int id)
        {
            return trHandler.GetAllHeadersById(id);
        }

        public static List<Detail> GetDetails(int id)
        {
            return trHandler.GetDetails(id);
        }
    }
}