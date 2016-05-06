using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DiagnosticCenter
{
    public partial class Patient : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BookAppointmentBLL retrieve = new BookAppointmentBLL();
                DataTable dt = retrieve.RetrieveData((string)Session["username"]);
                DataRow dr = dt.Rows[0];
                lblName.Text = "Welcome" +" "+ dr[0].ToString();
            }
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1));
            Response.Cache.SetNoStore();
            
        }

        protected void LinkButtonAppointment_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PresentationLayer/BookAppointment.aspx");
        }

        protected void LinkButtonStatus_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PresentationLayer/ApplicationStatus.aspx");
        }
        protected void LinkButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PresentationLayer/CancelAppointment.aspx");
        }

        protected void LinkButtonPwd_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PresentationLayer/ChangePasswordP.aspx");
        }

        protected void LinkButtonLogout_Click(object sender, EventArgs e)
        {
            Session.Remove("username");
            Session.RemoveAll();
            Response.Redirect("~/PresentationLayer/Login.aspx");
        }
    }
}