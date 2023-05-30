using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAAMEN_Project.Repository;
using RAAMEN_Project.Model;

namespace RAAMEN_Project.Handler
{
    public class Member
    {

        RamenRepository ramenRepo = new RamenRepository();
        UserRepository userRepo = new UserRepository();
        HeaderRepository headerRepo = new HeaderRepository();

        //BERHUBUNGAN SAMA RAMEN
        public List<Ramen> viewRamen()
        {
            List<Ramen> ramens = ramenRepo.getAllRamen();
            return ramens;
        }

        public Ramen orderRamen(int id)
        {
            Ramen ramen = ramenRepo.getRamen(id);
            //IF order buton is pressed, THEN:
            return ramen; //ni gw masi bingung antara di return ato langsung add ke cart aja
        }
        //------------------------------------------------------------


        //BERHUBUNGAN SAMA USER
        public User viewProfile(int id)
        {
            User user = userRepo.GetUser(id);
            return user;
        }

        public void updateProfile(int id, int roleId, string username, string email, string gender,
            string password)
        {
            userRepo.updateUser(id, roleId, username, email, gender, password);
        }
        //------------------------------------------------------------

        //TRANSACTION
        public List<Header> viewTransactionHistory()
        {
            List<Header> transcationHistories = headerRepo.GetAll();
            return transcationHistories;
        }
        //------------------------------------------------------------
    }

}