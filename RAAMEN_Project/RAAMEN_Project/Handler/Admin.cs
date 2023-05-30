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
        HeaderRepository headerRepo = new HeaderRepository();
        DetailRepository detailRepo = new DetailRepository();


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
            List<Header> transactions = headerRepo.GetAll();
            return transactions;
        }

        public List<Detail> viewReport()
        {
            List<Detail> reports = detailRepo.GetAll();//ini report tuh ngambil dari detail apa header ya
            return reports;
        }

        //------------------------------------------------------------

    }

}