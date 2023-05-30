using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Model;
using RAAMEN_Project.Factory;

namespace RAAMEN_Project.Repository
{
    public class RamenRepository : IRepository<Ramen>
    {
        public void Add(Ramen newRamen)
        {
            Database.getInstance().Ramen1.Add(newRamen);
        }

        public void Delete(int id)
        {
            Database.getInstance().Ramen1.Remove(GetById(id));
        }

        public List<Ramen> GetAll()
        {
            return Database.getInstance().Ramen1.ToList();
        }

        public Ramen GetById(int id)
        {
            return Database.getInstance().Ramen1.Find(id);
        }

        public void Update(int id, Ramen entity)
        {
            Ramen ramen = GetById(id);
            ramen.id = entity.id;
            ramen.Meatid = entity.Meatid;
            ramen.Name = entity.Name;
            ramen.Broth = entity.Broth;
            ramen.Price = entity.Price;

            Database.getInstance().SaveChanges();
        }
    }
    /*public class RamenRepository
    {
        private Database1Entities1 db = Database.getInstance();

        public List<Ramen> getAllRamen()
        {
            List<Ramen> ramens = db.Ramen1.ToList();
            return ramens;
        }

        public Ramen getRamen(int id)
        {
            return db.Ramen1.Find(id);
        }

        public void addRamen(int id, int meatId, string name, string broth, string price)
        {
            Ramen ramen = RamenFactory.CreateRamen(id, meatId, name, broth, price);
            db.Ramen1.Add(ramen);
            db.SaveChanges();
        }

        public void delRamen(int id)
        {
            db.Ramen1.Remove(db.Ramen1.Find(id));
            db.SaveChanges();
        }

        public void updateRamen(int id, int meatId, string name, string broth, string price)
        {
            Ramen ramen = db.Ramen1.Find(id);
            ramen.Meatid = meatId;
            ramen.Name = name;
            ramen.Broth = broth;
            ramen.Price = price;

            db.SaveChanges();
        }

    }*/
}