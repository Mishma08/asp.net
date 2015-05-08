using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlanMyEvents
{
    public partial class EditEvent : System.Web.UI.Page
    {

        private Event eventToEdit;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Security reasones
            if (Session["UserName"] == null)
                Response.Redirect("/HomePage.aspx", true);

            if (Session["EventId"] == null)
            {
                NoEventAlert();//If there is no events on yousers page
                Response.Redirect("/User.aspx", true);
            }

            eventToEdit = BLL.GetEvent(Session["EventId"].ToString());

            if (!Page.IsPostBack)//If the page isn't posting back do..
            {
                EventType.ClearSelection(); //making sure the previous selection has been cleared
                //Check which type of event to select
                if (eventToEdit.Type.Equals("Birthday"))
                {
                    EventType.Items.FindByValue("Birthday").Selected = true;
                    //EventType.SelectedIndex = 0;
                }
                else if (eventToEdit.Type.Equals("Wedding"))
                {
                    EventType.Items.FindByValue("Wedding").Selected = true;
                    //EventType.SelectedIndex = 1;
                }
                else if (eventToEdit.Type.Equals("Bar Mizva"))
                {
                    EventType.Items.FindByValue("Bar Mizva").Selected = true;
                    //EventType.SelectedIndex = 2;
                }
                else//If "Other" has been chosen
                {
                    //EventType.SelectedIndex = 3;
                    TextBoxEventType.Visible = true;
                    TextBoxEventType.Text = eventToEdit.Type;
                }

                TextBoxBdate.Text = eventToEdit.Date;
            }
            
        }
        //Extra functions for the "Other" selection
        protected void itemSelected(object sender, EventArgs e)
        {
            DropDownList list = (sender as DropDownList);
            if (list.SelectedValue.ToString().Equals("Other"))
                TextBoxEventType.Visible = true;
            else
                TextBoxEventType.Visible = false;
        }

        //Execute the submit button
        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string type;
            if (EventType.SelectedValue.ToString().Equals("Other"))
                type = TextBoxEventType.Text;
            else
                type = EventType.SelectedValue.ToString();

            BLL.InsertEvent(Session["UserName"].ToString(), type, TextBoxBdate.Text);//Insert the edited information to a new Event and insert the Event to The DB 
            BLL.RemoveEvent(Session["EventId"].ToString());//Removes the older edited Event
            Response.Redirect("/User.aspx", true); //Go back to the User page
        }

        //function which Alerts to the user that his event pade is empty - no events to edit
        private void NoEventAlert()
        {
            string message = "No event to edit!";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        }
    }
}