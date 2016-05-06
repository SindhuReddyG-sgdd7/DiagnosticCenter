using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DiagnosticCenter
{
    public partial class CancelAppointment : System.Web.UI.Page
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

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            int num;
            bool isnumber = int.TryParse(TxtAppID.Text, out num);
            if (isnumber)
            {
                CancelBLL regBLL = new CancelBLL();
                DataTable dt = regBLL.SearchAppBLL((string)Session["username"],TxtAppID.Text);
                if (dt.Rows.Count == 0)
                {
                    DetailsView1.Visible = false;
                    LabelSuccess.Visible = true;
                    LabelSuccess.Text = "Invalid Application ID";
                    ButtonCancel.Visible = false;
                }
                else
                {
                    LabelSuccess.Visible = false;
                    DetailsView1.Visible = true;
                    DetailsView1.DataSource = dt;
                    DetailsView1.DataBind();
                    ButtonCancel.Visible = true;
                }
            }
            else if (String.IsNullOrEmpty(TxtAppID.Text))
            {
                LabelSuccess.Visible = true;
                LabelSuccess.Text = "Please enter!";
            }
            else
            {
                LabelSuccess.Visible = true;
                LabelSuccess.Text = "Enter only integers!";
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            CancelBLL regBLL = new CancelBLL();
            bool canceled = regBLL.CancelAppBLL((string)Session["username"],TxtAppID.Text);
            DetailsView1.Visible = false;
            LabelSuccess.Visible = true;
            if (canceled)
            {
                LabelSuccess.Text = "Appointment Cancelled Successfully!";
            }
            else
            {
                LabelSuccess.Text = "Please Enter Your Appointment ID";
            }
        }
                
    }
}