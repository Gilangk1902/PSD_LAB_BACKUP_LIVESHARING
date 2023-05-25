using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using RAAMEN_Project.Model;

namespace RAAMEN_Project.Repository
{
    public class HeaderRepository : IRepository<Model.Header>
    {
        Database1Entities1 db = Database.getInstance();

        public void Add(Model.Header newHeader)
        {
            db.Headers.Add(newHeader);
        }

        public void Delete(int id)
        {
            db.Headers.Remove(db.Headers.Find(id));
        }

        public List<Model.Header> GetAll()
        {
            return db.Headers.ToList();
        }

        public Model.Header GetById(int id)
        {
            return db.Headers.Find(id);
        }

        public void Update(int id, Model.Header entity)
        {
            Model.Header header = db.Headers.Find(id);
            header.Date = entity.Date;
            header.CustomerId = entity.CustomerId;
            header.StaffId = entity.StaffId;
        }
    }
}