using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Repository;
using RAAMEN_Project.Model;

namespace RAAMEN_Project.Handler
{
    public class Staff
    {
        
        RamenRepository ramenRepo = new RamenRepository();
        UserRepository userRepo = new UserRepository();

        //BERHUBUNGAN SAMA RAMEN
        public void insertRamen(int id, int meatId, string name, string broth, string price)
        {
            //pake controller
            //ramenRepo.addRamen(id, meatId, name, broth, price);
        }

        public void updateRamen(int id, int meatId, string name, string broth, string price)
        {
            //pake controller
            //ramenRepo.updateRamen(id, meatId, name, broth, price);
        }

        public void delRamen(int id)
        {
            //pake controller
            //ramenRepo.delRamen(id);
        }
        //------------------------------------------------------------


        //BERHUBUNGAN SAMA USER
        /*public List<User> viewCustomers()
        {
            List<User> cust = userRepo.GetAllCustomer(); 
            return cust;
        }

        public User viewProfile(int id)
        {
            User user = userRepo.GetUser(id);
            return user;
        }

        public void updateProfile(int id, int roleId, string username, string email, string gender,
            string password)
        {
            userRepo.updateUser(id, roleId, username, email, gender, password);
        }*/
        //------------------------------------------------------------
    }

}