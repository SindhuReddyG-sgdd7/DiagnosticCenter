using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DiagnosticCenter
{
    public partial class Staff : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["username"] == null)
                {
                    Response.Redirect("~/PresentationLayer/Login.aspx");
                }
                else
                {
                    BookAppointmentBLL retrieve = new BookAppointmentBLL();
                    DataTable dt = retrieve.RetrieveDataStaff((string)Session["username"]);
                    DataRow dr = dt.Rows[0];
                    lblStaff.Text = "Welcome" +" "+ dr[0].ToString();
                }
            }
            else
            {
                if (Session["username"] == null)
                {
                    Response.Redirect("~/PresentationLayer/Login.aspx");
                }

            }
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1));
            Response.Cache.SetNoStore();
        }

        protected void LinkButtonPatient_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PresentationLayer/AddPatient.aspx");
        }

        protected void LinkButtonSchedule_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PresentationLayer/ViewSchedule.aspx");
        }

        protected void LinkButtonPwd_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PresentationLayer/ChangePasswordS.aspx");
        }

        protected void LinkButtonLogout_Click(object sender, EventArgs e)
        {
            Session.Remove("username");
            Session.RemoveAll();
            Response.Redirect("~/PresentationLayer/Login.aspx");
        }

        
    }
}