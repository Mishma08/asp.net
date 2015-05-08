using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanMyEvents
{
    public class Event
    {

     //Loval variabels   
	string id;
	string name;
    string type;
    string date;
    //GET/Set Functions
	public string Id
	{
		get { return id; }
		set { id = value; }
	}	
	public string Name
	{
		get { return name; }
		set { name = value; }
	}
    public string Type
	{
		get { return type; }
		set { type = value; }
	}	

    public string Date
	{
		get { return date; }
		set { date = value; }
	}	
	//Constructors
	public Event()
	{
		this.id = "";
		this.name = "";
        this.type="";
        this.date="";
	}
	public Event(string id , string name, string type, string date)
	{
		this.id = id;
		this.name = name;
        this.date=date;
        this.type = type;
	}
	public Event(Event other)
	{
		this.id = other.id;
		this.name = other.name;
        this.date = other.date;
        this.type = other.type;
	}
    }
}