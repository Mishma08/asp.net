using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlanMyEvents
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRegister_Click1(object sender, EventArgs e)
        {
         
            if (BLL.UserExist(TextBoxUserName.Text))
            {
                Alert();
                TextBoxUserName.Text = "";
            }
            else
            {
                BLL.InsertUser(TextBoxUserName.Text, TextBoxPassword.Text, TextBoxMail.Text, TextBoxFname.Text, TextBoxLname.Text, TextBoxBdate.Text);
                Success();
                Session["UserName"] = TextBoxUserName.Text;

                Response.Redirect("/User.aspx", true);
            }
        }
        //Alert massage about exicting user
        private void Alert()
        {
            string message = "User already exists!";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        }
        //Success massage - executes after submmision
        private void Success()
        {
            string message = "Success!";
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