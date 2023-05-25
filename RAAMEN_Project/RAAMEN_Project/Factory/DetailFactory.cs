using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Model;

namespace RAAMEN_Project.Factory
{
    public class DetailFactory
    {
        public static Detail Create(int header_id, int ramen_id, int quantity)
        {
            return new Detail()
            {
                Headerid = header_id,
                Ramenid = ramen_id,
                Quantity = quantity
            };
        }
    }

}