using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiagnosticCenter
{
    public partial class AddPatient : System.Web.UI.Page
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
                    else if ((string)Session["Role"] == "Patient")
                    {
                        Response.Redirect("~/PresentationLayer/PatientPage.aspx");
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
            txtUserName.Text = (string)Session["username"];
            lblDetialsStatus.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                AddPatientDetailsBLL regBLL = new AddPatientDetailsBLL();
                bool inserted = regBLL.AddPatient((string)Session["username"], TxtName.Text, rblGender.SelectedValue.ToString(), TxtAge.Text, DropDownListService.SelectedValue.ToString(), TxtDoctor.Text);
                lblDetialsStatus.Visible = true;
                if (inserted)
                {
                    lblDetialsStatus.Text = "Patient Details are added successfully";
                    Panel1.Visible = false;
                }
                else
                    lblDetialsStatus.Text = "Patient Details are not added ";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PresentationLayer/StaffPage.aspx");
        }
    }
}