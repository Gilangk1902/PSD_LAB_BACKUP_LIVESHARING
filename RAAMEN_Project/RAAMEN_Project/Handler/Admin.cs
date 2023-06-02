using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Repository;
using RAAMEN_Project.Model;

namespace RAAMEN_Project.Handler
{
    public class Admin
    {
        UserRepository userRepo = new UserRepository();
        TransactionRepository trRepo = new TransactionRepository();


        //BERHUBUNGAN SAMA USER
        public List<User> viewCustomers()
        {
            List<User> cust = userRepo.GetAllCustomer();
            return cust;
        }

        public List<User> viewStaffs()
        {
            List<User> staff = userRepo.GetAllStaff();
            return staff;
        }

        //------------------------------------------------------------

        //BERHUBUNGAN SAMA TRANSACTION
        public List<Header> viewAllTransaction()
        {
            List<Header> transactions = trRepo.GetAllHeader();
            return transactions;
        }

        //------------------------------------------------------------

    }

}