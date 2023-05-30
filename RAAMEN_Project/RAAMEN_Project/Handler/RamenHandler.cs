using RAAMEN_Project.Factory;
using RAAMEN_Project.Model;
using RAAMEN_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAAMEN_Project.Handler
{
    public class RamenHandler : IHandler<Ramen>
    {
        RamenRepository ramenRepository = new RamenRepository();
        public void Add(Ramen newRamen)
        {
            ramenRepository.Add(newRamen);
        }

        public void Delete(int id)
        {
            ramenRepository.Delete(id);
        }

        public Ramen Get(int id)
        {
            return ramenRepository.GetById(id);
        }

        public List<Ramen> GetAll()
        {
            return ramenRepository.GetAll();
        }

        public void Update(int id, Ramen newRamen)
        {
            ramenRepository.Update(id, newRamen);
        }
    }
}
