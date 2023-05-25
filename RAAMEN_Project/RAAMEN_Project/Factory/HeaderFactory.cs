using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Model;

namespace RAAMEN_Project.Factory
{
    public class HeaderFactory
    {
        public static Header Create(int id, int customer_id, int staff_id, DateTime date)
        {
            return new Header()
            {
                id = id,
                CustomerId = customer_id,
                StaffId = staff_id,
                Date = date
            };
        }
    }

}