using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Model;

namespace RAAMEN_Project.Factory
{
    public class TransactionFactory
    {
        //HEADER
        public static Header CreateHeader(int id, int customer_id, int staff_id, DateTime date)
        {
            return new Header()
            {
                id = id,
                CustomerId = customer_id,
                StaffId = staff_id,
                Date = date
            };
        }

        //DETAIL
        public static Detail CreateDetail(int header_id, int ramen_id, int quantity)
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