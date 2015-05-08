using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient; //For the sql usage

namespace PlanMyEvents
{
    public class DAL
    {

        static SqlConnection connection;
        static SqlDataReader reader;
        static SqlCommand command;
        static string sqlString;

        //Get from the Data Base all the events and put it in a list of type Event
        public static List<Event> GetAllEvents()
        {
            List<Event> result = new List<Event>();
            Event events = new Event();
            sqlString = "SELECT * " +
                        "FROM Events";

            CreateConnection();
            ExecuteSqlCommand();

            while (reader.Read())
            {
                events.Id = reader["Id"].ToString();
                events.Name = reader["UserName"].ToString();
                events.Date = reader["EventDate"].ToString();
                events.Type = reader["EventType"].ToString();

                result.Add(new Event(events));
            }

            CloseConnection();
            return result;
        }
        //Get from the Data Base specific user by name
        public static User GetUser(string name)
        {
            User result = new User();
            sqlString = "SELECT * " +
                        "FROM Reg " +
                        "WHERE UserName LIKE '" + name + "'";

            CreateConnection();
            ExecuteSqlCommand();

            if (reader.Read())
            {
                result.UserName = reader["UserName"].ToString();
                result.Password = reader["Password"].ToString();
                result.Email = reader["Email"].ToString();
                result.FirstName = reader["FirstName"].ToString();
                result.LastName = reader["LastName"].ToString();
                result.BirthDate = reader["BirthDate"].ToString();

            }
            else
                result = null;

            CloseConnection();
            return result;
        }
        //Get from the Data Base all the events of a specific user
        public static List<Event> GetEventsByUser(string userName) {
            List<Event> result = new List<Event>();
            Event events = new Event();
           
             sqlString = "SELECT * " +
                            "FROM Events " +
                            "WHERE UserName LIKE '" + userName + "'";
          
               
            
            CreateConnection();
            ExecuteSqlCommand();

            while (reader.Read())
            {
                events.Id =   reader["Id"].ToString();
                events.Name = reader["UserName"].ToString();
                events.Date = reader["EventDate"].ToString();
                events.Type = reader["EventType"].ToString(); ;

                result.Add(new Event(events));
            }

            CloseConnection();
            return result;
        }
        //Get from the Data Base all the events and put it in
        public static void InsertUser(string userName, string password, string email, string firstName,string lastName, string bDate)
        {
            sqlString = "INSERT INTO Reg"  +
                        " VALUES (" + "'" + userName + "'" + "," + "'" + password + "'" +"," + "'" + email + "'"+"," + "'" + firstName + "'"+"," + "'" + lastName + "'"+
                        "," + "'" + bDate + "'"+")";

            CreateConnection();
            ExecuteSqlCommand();
            CloseConnection();
         
        }

        
        public static bool RemoveEvent(string id)
        {
            if (GetEvent(id) == null)
            {
                return false;
            }

            sqlString = "DELETE FROM Events " +
                        "WHERE Id='" + id + "'";

            CreateConnection();
            ExecuteSqlCommand();
            CloseConnection();

            return true;
        }
        public static Event GetEvent(string id)
        {
            Event events = new Event();
            sqlString = "select * from Events where Id like '" + id + "'";

            CreateConnection();
            ExecuteSqlCommand();

            if (reader.Read())
            {
                events.Id = reader["Id"].ToString();
                events.Name = reader["UserName"].ToString();
                events.Date = reader["EventDate"].ToString();
                events.Type = reader["EventType"].ToString();
            }
            else
                events = null;

            CloseConnection();
            return events;
        }
        public static void InsertEvent(string name, string type,string date)
        {
            sqlString = "INSERT INTO Events (UserName,EventType,EventDate) "  +
                        "VALUES (" + "'" + name + "'" + "," + "'" + type + "'" + "," + "'" + date + "'" + ")";

            CreateConnection();
            ExecuteSqlCommand();
            CloseConnection();
        }
       
        //This function creates a SQL connection to the data base using the connection string - (defined in Web.config)
        private static void CreateConnection()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            /*string connectionString =	@"Data Source=(LocalDB)\v11.0;" + 
                                            @"AttachDbFilename=c:\users\אושרי\documents\visual studio 2013\Projects\PlanMyEvents\PlanMyEvents\App_Data\DBEvents_log.ldf;" + 
                                            @"Integrated Security=True;" +
                                            @"Connect Timeout=30";*/
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
        //Creates a new SQL command an executed it
        private static void ExecuteSqlCommand()
        {
            command = new SqlCommand(sqlString, connection);
            reader = command.ExecuteReader();
        }
        //Closing the SQL connection
        private static void CloseConnection()
        {
            connection.Close();
            reader.Close();
        } 
    }
}