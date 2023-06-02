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
    public class MeatHandler : IHandler<Meat>
    {
        private MeatRepository meatRepository = new MeatRepository();

        public void Add(Meat newMeat)
        {
            meatRepository.Add(newMeat);
        }

        public void Delete(int id)
        {
            meatRepository.Delete(id);
        }

        public Meat Get(int id)
        {
            return meatRepository.GetById(id);
        }

        public List<Meat> GetAll()
        {
            return meatRepository.GetAll();
        }

        public void Update(int id, Meat newMeat)
        {
            meatRepository.Update(id, newMeat);
        }

        public List<String> GetAllNames()
        {
            List<String> names = (from m in meatRepository.GetDatabase1Entities1().Meats select m.name).ToList();
            return names;
        }

        public int GetMeatId(string meat_selector)
        {
            return (from Meat in meatRepository.GetDatabase1Entities1()
                    .Meats where Meat.name == meat_selector select Meat.id).FirstOrDefault();
        }
    }
}
