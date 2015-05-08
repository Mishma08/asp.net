using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanMyEvents
{
    public class User
    {
        //Local Variables
        string username;
        string birthDate;
        string email;
        string password;
        string firstName;
        string lastName;
        List<Event> events;
        //GET/SET functions
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        //Constructors
        public User()
	    {
		  this.username = "";
          this.password = "";
          this.birthDate = "";
          this.email = "";
          this.firstName = "";
          this.lastName = "";
          this.events = new List<Event>();
	    }
        public User(string username, string birthDate, string password, string email, string firstName, string lastName)
        {
            this.username = username;
            this.password = password;
            this.birthDate = birthDate;
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
            this.events = new List<Event>();
        }
        public User(User other)
        {
            this.username = other.username;
            this.password = other.password;
            this.birthDate = other.birthDate;
            this.email = other.email;
            this.firstName = other.firstName;
            this.lastName = other.lastName;
            this.events = other.events;
        }
    }
}