using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiagnosticCenter
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
            if (!IsPostBack)
            {
                
                EnableViewState = false;
                Session["username"] = null;
                Session["password"] = null;
            }
            else
            {
                
                Session["username"] = txtUsername.Text;
                Session["password"] = txtPassword.Text;
            }
                
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            
            UserAuthenticationBLL userAuth = new UserAuthenticationBLL();
            string userRole = userAuth.UserAuthentication(txtUsername.Text,txtPassword.Text);
            Session["Role"] = userRole;
            if (userRole != null)
            {
                if (CheckRem.Checked)
                {
                    Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(30);
                    Response.Cookies["Password"].Expires = DateTime.Now.AddDays(30);
                    Response.Cookies["UserName"].Value = txtUsername.Text.Trim();
                    Response.Cookies["Password"].Value = txtPassword.Text.Trim();
                }
                switch (userRole)
                {
                    case "Manager": Response.Redirect("~/PresentationLayer/ManagerPage.aspx");
                        break;
                    case "Patient": Response.Redirect("~/PresentationLayer/PatientPage.aspx");
                        break;
                    case "Staff": Response.Redirect("~/PresentationLayer/StaffPage.aspx");
                        break;
                    default: Response.Write("<script>alert('Invalid Username or Password')</script>");
                        break;
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid username and password')</script>");
            }
        }

        protected void btnSignUP_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PresentationLayer/PatientRegistration.aspx");
        }

        protected void txtUsername_TextChanged(object sender, EventArgs e)
        {
            bool valid = false;
            HttpCookieCollection cookies = Request.Cookies;
            for (int i = 0; i < cookies.Count; i++)
            {
                if (txtUsername.Text == cookies[i].Value && cookies[i].Name == "UserName")
                {
                    txtPassword.Attributes["value"] = cookies[i + 1].Value;
                    valid = true;
                }
            }
           SetFocus(txtPassword);
 

        }
    }
}