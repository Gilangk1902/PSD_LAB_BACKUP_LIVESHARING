using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RAAMEN_Project.Handler
{
    interface IHandler<T>
    {
        void Add(T type);
        void Delete(int id);
        void Update(int id, T type);
        List<T> GetAll();
        T Get(int id);
    }
}