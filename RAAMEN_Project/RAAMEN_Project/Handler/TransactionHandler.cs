using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Factory;
using RAAMEN_Project.Model;
using RAAMEN_Project.Repository;

namespace RAAMEN_Project.Handler
{
    public class TransactionHandler : IHandler<Header>
    {
        TransactionRepository trRepo = new TransactionRepository();

        public void Add(Header type)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Header Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Header> GetAll()
        {
            return trRepo.GetAllHeader();
        }

        public List<Header> GetAllHeadersById(int id)
        {
            return trRepo.GetAllHeaderById(id);
        }

        public void Update(int id, Header type)
        {
            throw new NotImplementedException();
        }
    }
}