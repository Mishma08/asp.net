using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanMyEvents
{
    public class BLL
    {
        //The BLL layer using the DAL layer for exectuing the GUI commands
        public static List<Event> GetAllEvents()
        {
            return DAL.GetAllEvents();
        }


        public static void InsertEvent(string name, string type, string date)
        {
            DAL.InsertEvent(name,type,date);
        }

        public static List<Event> GetProductsLike(string id, string name)
        {
          
                return DAL.GetEventsByUser( name);
        }

        public static bool RemoveEvent(string id)
        {
            return DAL.RemoveEvent(id);
        }

        public static Event GetEvent(string id)
        {
            return DAL.GetEvent(id);
        }


        public static void InsertUser(string name, string password, string email, string firstName, string lastNmae, string bDtate)
        {
            DAL.InsertUser(name,password,email,firstName,lastNmae,bDtate);
        }

       
        public static User GetUser(string name)
        {
            
            return DAL.GetUser(name);
        }

        public static bool UserExist(string name) {
            if (GetUser(name) == null)
                return false;
            return true;
        }



        public static List<Event> GetUserEvents(string name)
        {
            return DAL.GetEventsByUser(name);
        }

        public static bool IsPasswordCorrect(string userName, string password)
        {
            User user = DAL.GetUser(userName);
            if(user != null)
            {
                if (user.Password.Equals(password))
                    return true;
            }
            return false;
        }
    }
}