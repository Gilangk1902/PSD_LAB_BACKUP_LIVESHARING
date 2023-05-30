using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RAAMEN_Project.Controllers
{
    interface IController<T>
    {
        void Add(T entity);
        void Delete(int id);
        void Update(int id, T entity);
    }
}