using RAAMEN_Project.Factory;
using RAAMEN_Project.Handler;
using RAAMEN_Project.Model;
using RAAMEN_Project.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Helpers;

namespace RAAMEN_Project.Controllers
{
    public class UserController
    {
        private static UserHandler userHandler = new UserHandler();
        private static UserRepository userRepository = new UserRepository();

        public static string validateLogin(string username, string password, bool rememberMe)
        {
            if (username.Length == 0)
            {
                return "Username cannot be empty";
            }

            if (password.Length == 0)
            {
                return "Password cannot be empty";
            }

            User user = IsValidCredential(username, password);

            if (user == null)
            {
                return "Credential is not valid";
            }
            List<Ramen> cart = new List<Ramen>();
            HttpContext.Current.Session["Role"] = "User";
            HttpContext.Current.Session["User"] = user;
            HttpContext.Current.Session["Username"] = username;
            HttpContext.Current.Session["ID"] = user.Id;
            HttpContext.Current.Session["Email"] = user.Email;
            HttpContext.Current.Session["Cart"] = cart;
            if (rememberMe)
            {
                HttpCookie userCookie = new HttpCookie("UserCookie");
                userCookie.Values.Add("UserId", user.Id.ToString());
                userCookie.Values.Add("Username", user.Username);
                userCookie.Values.Add("Password", password);
                userCookie.Expires = DateTime.Now.AddHours(24);
                HttpContext.Current.Response.Cookies.Add(userCookie);
            }
            return null;
        }

        public static string validateRegister(int roleId, string username, string email, string gender,
            string password, string confirmPassword)
        {
            if (username.Length < 5 || username.Length > 15)
            {
                return "Username must be between 5 and 15 characters.";
            }

            if (!email.EndsWith(".com"))
            {
                return "Email Must ends with ‘.com’.";
            }
        
            if(gender.Length == 0)
            {
                return "Gender Must be chosen.";
            }

            if(password != confirmPassword)
            {
                return "Password must be the same with confirm password.";
            }

            if (confirmPassword != password)
            {
                return "Confirm password Must be the same with password.";
            }

            //register
            userHandler.register(roleId, username, email, gender, password);

            return null;
        }

        public static User IsValidCredential(string username, string password)
        {
            return userHandler.IsValidCredential(username, password);
        }

        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public static void Update(int target_id, int role_id,string username, string email, string gender, 
            string password, string confirm_password)
        {
            if (password.Equals(confirm_password))
            {
                userHandler.Update(target_id, UserFactory.CreateUser(role_id, username, email, gender, password));
            }
        }
        public static string SetErrorMessage(string password, string confirm_password)
        {
            if (!password.Equals(confirm_password))
            {
                return "password doesnt match";
            }
            return "";
        }
        public static User Get(int id)
        {
            return userHandler.GetUser(id);
        }
        public static List<User> GetAllCustomer()
        {
            return userHandler.GetAllCustomer();
        }
        public static List<User> GetAllStaff()
        {
            return userHandler.GetAllStaff();
        }
        public static Role getRole(int id)
        {
            return userHandler.GetRole(id);
        }
    }
}