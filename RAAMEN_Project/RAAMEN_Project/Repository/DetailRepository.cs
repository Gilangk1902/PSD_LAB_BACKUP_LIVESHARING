using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Model;

namespace RAAMEN_Project.Repository
{
    public class DetailRepository : IRepository<Detail>
    {
        Database1Entities1 db = Database.getInstance();

        public void Add(Detail factory)
        {
            db.Details.Add(factory);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Details.Remove(db.Details.Find(id));
            db.SaveChanges();
        }

        public List<Detail> GetAll()
        {
            return db.Details.ToList();
        }

        public Detail GetById(int id)
        {
            return db.Details.Find(id);
        }

        public void Update(int id, Detail entity)
        {
            Detail detail = db.Details.Find(id);
            detail.Quantity = entity.Quantity;
            detail.Ramenid = entity.Ramenid;
            detail.Headerid = entity.Headerid;
            db.SaveChanges();
        }
    }
}