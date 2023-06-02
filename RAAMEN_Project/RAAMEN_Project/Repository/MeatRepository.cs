using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Model;
using RAAMEN_Project.Factory;

namespace RAAMEN_Project.Repository
{
    public class MeatRepository : IRepository<Meat>
    {
        private Database1Entities1 db = DatabaseSingleton.getInstance();

        public void Add(Meat meat)
        {
            db.Meats.Add(meat);
            
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Meats.Remove(db.Meats.Find(id));
            db.SaveChanges();
        }

        public List<Meat> GetAll()
        {
            return db.Meats.ToList();
        }

        public Meat GetById(int id)
        {
            return db.Meats.Find(id);
        }

        public void Update(int targetMeat_id, Meat newMeat)
        {
            Meat updatedMeat = db.Meats.Find(targetMeat_id);
            updatedMeat.name = newMeat.name;

            db.SaveChanges();
        }

        public Database1Entities1 GetDatabase1Entities1()
        {
            return db;
        }
    }
}