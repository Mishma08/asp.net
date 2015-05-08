using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlanMyEvents
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (BLL.UserExist(TextBoxUserName.Text))//Check if the user name exists
            {
                if (BLL.IsPasswordCorrect(TextBoxUserName.Text, TextBoxPassword.Text))//Check if the password is correct
                {
                    Session["UserName"] = TextBoxUserName.Text;
                    Response.Redirect("/User.aspx", true);
                }                    
                else//Massage to the User that his password is wrong
                    AlertWrongPassword();                
            }
            else
            {               
                AlertUserNotExist();   
            }
        }

        private void AlertUserNotExist()
        {
            string message = "User not exists!";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        }

        private void AlertWrongPassword()
        {
            string message = "Wrong Password!";
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