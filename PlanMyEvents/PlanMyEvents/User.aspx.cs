using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlanMyEvents
{
    public partial class User1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null) //if on page load the session is null then return to homepage - Security reasons
                Response.Redirect("/HomePage.aspx", true);

            try
            {
                List<Event> eventsList = BLL.GetUserEvents(Session["UserName"].ToString()); //get all user events from the bll
                BindItemsToTable(eventsList);
            }
            catch(Exception)
            {

            }
           
        }

        protected void ButtonEdit_Click(object sender, EventArgs e)
        {
            //Get the reference of the clicked button.
            Button button = (sender as Button);

            //Get the command argument
            string commandArgument = button.CommandArgument;

            Session["EventId"] = commandArgument;

            Response.Redirect("/EditEvent.aspx", true);
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            //Get the reference of the clicked button.
            Button button = (sender as Button);

            //Get the command argument
            string commandArgument = button.CommandArgument;

            BLL.RemoveEvent(commandArgument);
            Response.Redirect(Request.RawUrl.ToString()); // redirect on itself
        }

        private void BindItemsToTable(List<Event> eventsList)
        {
            // The the LIST as the DataSource
            this.events.DataSource = eventsList;

            // Then bind the repeater
            // The public properties become the columns of your repeater
            this.events.DataBind();
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("/AddEvent.aspx", true);
        }
        
    }
}