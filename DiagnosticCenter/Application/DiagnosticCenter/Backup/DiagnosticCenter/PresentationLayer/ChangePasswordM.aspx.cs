using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiagnosticCenter.PresentationLayer
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblChangePwd.Visible = false;
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

        protected void ButtonConfirm_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                UpdateLoginPasswordBLL updatePwd = new UpdateLoginPasswordBLL();
                bool updated = updatePwd.UpdateManagerPassword((string)Session["username"], txtOldPwd.Text, txtNewPwd.Text);
                lblChangePwd.Visible = true;
                if (updated)
                {
                    panelChangePwd.Visible = false;
                    lblChangePwd.Text = "Password Changed Successfully";
                    lblChangePwd.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblChangePwd.Text = "Password Not Changed.....Old Password is incorrect";
                    lblChangePwd.ForeColor = System.Drawing.Color.Red;
                }
            }

        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PresentationLayer/ManagerPage.aspx");
        }
    }
}