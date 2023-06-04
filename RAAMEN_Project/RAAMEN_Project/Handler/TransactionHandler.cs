using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Factory;
using RAAMEN_Project.Model;
using RAAMEN_Project.Repository;

namespace RAAMEN_Project.Handler
{
    public class TransactionHandler
    {
        TransactionRepository trRepo = new TransactionRepository();

        public void AddHeader(Header type)
        {
            trRepo.AddHeader(type);
        }

        public void AddDetail(Detail type)
        {
            trRepo.AddDetail(type);
        }

        public List<Header> GetAll()
        {
            return trRepo.GetAllHeader();
        }

        public List<Header> GetAllHeadersById(int id)
        {
            return trRepo.GetAllHeaderById(id);
        }

        public List<Detail> GetDetails(int id)
        {
            return trRepo.GetAllDetail(id);
        }
    }
}