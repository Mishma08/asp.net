using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlanMyEvents
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Redirect("/HomePage.aspx", true);
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            int x= 1;
        }
    }
}