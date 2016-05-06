using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DiagnosticCenter
{
    public partial class NestedMasterPage1 : System.Web.UI.MasterPage
    {
        public Label LabelOnNestedMasterPage
        {
            get
            {
                return this.lblOnNested;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            lblOnNested.Text = "Welcome" +" "+ (string)Session["username"];
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1));
            Response.Cache.SetNoStore();
        }

        protected void LinkButtonAddStaff_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PresentationLayer/StaffRegistration.aspx");
        }

        protected void LinkButtonViewStaff_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PresentationLayer/ViewStaffDetails.aspx");
        }

        protected void LinkButtonPwd_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PresentationLayer/ChangePasswordM.aspx");
        }

        protected void LinkButtonLogout_Click(object sender, EventArgs e)
        {
           
            Session.Remove("username");
            Session.RemoveAll();
            Response.Redirect("~/PresentationLayer/Login.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PresentationLayer/ConfirmRequests.aspx");
        }
    }
}