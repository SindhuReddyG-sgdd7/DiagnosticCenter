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
    public partial class WebForm2 : System.Web.UI.Page
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
                }
            }
            else
            {
                if (Session["username"] == null)
                {
                    Response.Redirect("~/PresentationLayer/Login.aspx");
                }

            }
            lblPassword.Visible = false;
            lblPwd.Visible = false;
            lblUser.Visible = false;
            lblUserName.Visible = false;
            lblExist.Visible = false;
            lblReg.Visible = false;
            //RangeValidator1.MaximumValue = DateTime.Today.AddYears(-18).ToShortDateString();
            //RangeValidator1.MinimumValue = DateTime.Today.AddYears(-41).ToShortDateString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                StaffRegistrationBLL regBLL = new StaffRegistrationBLL();
                string gender = RadioButtonListGender.SelectedValue;
                string[] credentials = new string[2];
                credentials = regBLL.RegisterDetailsBLL(TxtFN.Text, TxtLN.Text, gender, TxtDOB.Text, TxtAge.Text, TxtMobile.Text, TxtEmail.Text, TxtQual.Text, TxtExp.Text, TxtAddress.Text, TxtCity.Text, TxtPin.Text);
                if (credentials[0] == "Already Exist")
                {
                    lblExist.Visible = true;
                    lblExist.Text = credentials[0];
                }
                else
                {
                    lblReg.Visible = true;
                    staffReg.Visible = false;
                    lblTitle.Visible = false;
                    lblPwd.Visible = true;
                    lblUserName.Visible = true;
                    lblUser.Visible = true;
                    lblPassword.Visible = true;
                    lblPwd.Text = credentials[1];
                    lblUser.Text = credentials[0];
                    lblPwd.ForeColor = System.Drawing.Color.Green;
                    lblUserName.ForeColor = System.Drawing.Color.Green;
                }
                
            }
        }
    }
}