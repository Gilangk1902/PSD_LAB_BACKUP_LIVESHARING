using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RAAMEN_Project.Repository
{
    public interface  IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Update(int id, T entity);
        void Delete(int id);
        void Add(T factory); 
        //not using Add() if factory MUST used inside repository method, but the parameters in repo.create can be long af
    }
}