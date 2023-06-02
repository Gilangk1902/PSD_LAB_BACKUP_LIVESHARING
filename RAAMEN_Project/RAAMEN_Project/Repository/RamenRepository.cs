using RAAMEN_Project.Model;
using RAAMEN_Project.Repository;
using System.Collections.Generic;
using System.Linq;

public class RamenRepository :IRepository<Ramen>
{
    Database1Entities1 db = DatabaseSingleton.getInstance();
    public void Add(Ramen newRamen)
    {
        DatabaseSingleton.getInstance().Ramen1.Add(newRamen);
        newRamen.id = SetId();
        DatabaseSingleton.getInstance().SaveChanges();
    }

    private int SetId()
    {
        int id = 0;
        int lastId = (from ramen in db.Ramen1 select ramen.id).ToList().LastOrDefault();

        if (DatabaseSingleton.getInstance().Ramen1 == null)
        {
            id = 1;
        }
        else
        {
            id = lastId + 1;
        }
        return id;
    }

    public void Delete(int id)
    {
        DatabaseSingleton.getInstance().Ramen1.Remove(GetById(id));
        DatabaseSingleton.getInstance().SaveChanges();
    }

    public List<Ramen> GetAll()
    {
       return DatabaseSingleton.getInstance().Ramen1.ToList();
    }

    public Ramen GetById(int id)
    {
        return DatabaseSingleton.getInstance().Ramen1.Find(id);
    }

    public void Update(int id, Ramen newRamen)
    {
        Ramen ramen = GetById(id);
        ramen.Name = newRamen.Name;
        ramen.Broth = newRamen.Broth;
        ramen.Price = newRamen.Price;

        DatabaseSingleton.getInstance().SaveChanges();
    }
}