using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DiagnosticCenter
{
    public partial class WebForm6 : System.Web.UI.Page
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
                    if ((string)Session["Role"] == "Patient")
                    {
                        Response.Redirect("~/PresentationLayer/PatientPage.aspx");
                    }
                    else if ((string)Session["Role"] == "Staff")
                    {
                        Response.Redirect("~/PresentationLayer/StaffPage.aspx");
                    }
                    else
                    {
                        ViewStaffDetailsBLL viewDetails = new ViewStaffDetailsBLL();
                        DataTable dt = viewDetails.ViewStaff();
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
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

        protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            ViewStaffDetailsBLL viewDetails = new ViewStaffDetailsBLL();
            DataTable dt = viewDetails.ViewStaff();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}