using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiagnosticCenter
{
    public partial class ApplicationStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["username"] == null && Session["password"] == null)
                {
                    Response.Redirect("~/PresentationLayer/Login.aspx");
                }
                else
                {
                    if ((string)Session["Role"] == "Manager")
                    {
                        Response.Redirect("~/PresentationLayer/ManagerPage.aspx");
                    }
                    else if ((string)Session["Role"] == "Staff")
                    {
                        Response.Redirect("~/PresentationLayer/StaffPage.aspx");
                    }
                }
            }
            else
            {
                if (Session["username"] == null)
                {
                    Response.Redirect("~/PresentationLayer/Login.aspx");
                }

            }
        }

        protected void ButtonCheck_Click(object sender, EventArgs e)
        {
            int num;
            bool isnumber = int.TryParse(TxtAppID.Text, out num);
            if (isnumber)
            {
                ApplicationStatusBLL statusBLL = new ApplicationStatusBLL();
                string a = statusBLL.AppStatusBLL((string)Session["username"],TxtAppID.Text);
                if (String.IsNullOrEmpty(a))
                {
                    Label2.Visible = false;
                    Label3.Text = "Invalid Application ID";
                }
                else
                {
                    Label2.Visible = true;
                    Label3.Text = a;
                }
            }
            else if (String.IsNullOrEmpty(TxtAppID.Text))
            {
                Label3.Text = "Please enter!";
                Label2.Visible = false;
            }
            else
            {
                Label3.Text = "Enter only integers!";
                Label2.Visible = false;
            }          

        }
    }
}