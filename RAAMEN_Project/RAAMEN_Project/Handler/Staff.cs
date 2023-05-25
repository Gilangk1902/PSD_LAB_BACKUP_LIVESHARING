using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Repository;

namespace RAAMEN_Project.Handler
{
    public class Staff
    {
        
        RamenRepository ramenRepo = new RamenRepository();
        UserRepository userRepo = new UserRepository();

        //BERHUBUNGAN SAMA RAMEN
        public void insertRamen(int id, int meatId, string name, string broth, string price)
        {
            ramenRepo.addRamen(id, meatId, name, broth, price);
        }

        public void updateRamen(int id, int meatId, string name, string broth, string price)
        {
            ramenRepo.updateRamen(id, meatId, name, broth, price);
        }

        public void delRamen(int id)
        {
            ramenRepo.delRamen(id);
        }
        //------------------------------------------------------------


        //BERHUBUNGAN SAMA USER
        public void viewCustomers()
        {
            userRepo.GetAllUser();
        }

        public void viewProfile(int id)
        {
            userRepo.GetUser(id);
        }

        public void updateProfile(int id, int roleId, string username, string email, string gender,
            string password)
        {
            userRepo.updateUser(id, roleId, username, email, gender, password);
        }
        //------------------------------------------------------------
    }

}