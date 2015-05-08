using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlanMyEvents
{
    public partial class AddEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Security reasones - user can go directlly to the page
            if (Session["UserName"] == null)
                Response.Redirect("/HomePage.aspx", true);
        }
        //Executing the combo-box of the event
        protected void itemSelected(object sender, EventArgs e)
        {
            DropDownList list = (sender as DropDownList);
            //If "Other" selected - open the text box for manual usage
            if(list.SelectedValue.ToString().Equals("Other"))
                TextBoxEventType.Visible = true;
            else
                TextBoxEventType.Visible = false;
        }
        //Executes the "Add event" button
        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string type;
            if(EventType.SelectedValue.ToString().Equals("Other"))
                type = TextBoxEventType.Text;
            else
                type = EventType.SelectedValue.ToString();

            BLL.InsertEvent(Session["UserName"].ToString(), type, TextBoxBdate.Text);

            Response.Redirect("/User.aspx", true);
        }
    }
}