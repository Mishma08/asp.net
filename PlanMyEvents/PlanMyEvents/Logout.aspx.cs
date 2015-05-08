using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlanMyEvents
{
    public partial class Logout : System.Web.UI.Page
    {
        //This is an "invisibol" page for the User
        //It's clear the session and redirect to the Home page
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("/HomePage.aspx", true);
        }
    }
}