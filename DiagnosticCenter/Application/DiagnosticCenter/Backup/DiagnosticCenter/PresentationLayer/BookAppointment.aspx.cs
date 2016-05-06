using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DiagnosticCenter
{
    public partial class BookAppointment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["username"] != null)
                {
                    if ((string)Session["Role"] == "Manager")
                    {
                        Response.Redirect("~/PresentationLayer/ManagerPage.aspx");
                    }
                    else if ((string)Session["Role"] == "Staff")
                    {
                        Response.Redirect("~/PresentationLayer/StaffPage.aspx");
                    }
                    else
                    {
                        BookAppointmentBLL retrieve = new BookAppointmentBLL();
                        DataTable dt = retrieve.RetrieveData((string)Session["username"]);
                        DataRow dr = dt.Rows[0];
                        TxtFN.Text = dr[0].ToString();
                        TxtGender.Text = dr[1].ToString();
                        lblAppointmentID.Visible = false;
                    }
                }
                else
                {
                    Response.Redirect("~/PresentationLayer/Login.aspx");
                }
            }
            else
            {
                if (Session["username"] == null)
                {
                    Response.Redirect("~/PresentationLayer/Login.aspx");
                }

            }
            RangeValidator1.MinimumValue = DateTime.Today.AddDays(1).ToShortDateString();
            RangeValidator1.MaximumValue = DateTime.Today.AddDays(7).ToShortDateString();

        }               

        protected void ButtonConfirm_Click(object sender, EventArgs e)
        {
            
            if (Page.IsValid)
            {
                
                BookAppointmentBLL retrieve = new BookAppointmentBLL();
                DataTable dt = retrieve.RetrieveData((string)Session["username"]);
                DataRow dr = dt.Rows[0];
                TxtFN.Text = dr[0].ToString();
                TxtGender.Text = dr[1].ToString();
                string firstName = dr[0].ToString();
                string gender = dr[1].ToString();
                BookAppointmentBLL BookBLL = new BookAppointmentBLL();
                string appointmentID = BookBLL.BookAppBLL((string)Session["username"], firstName, gender, DropDownListService.Text, TxtDate.Text, TxtReason.Text);
                if (appointmentID == "Already Exist")
                {
                    lblAppointmentID.Visible = true;
                    lblAppointmentID.Text = appointmentID;
                }
                else
                {
                    panelAppiontment.Visible = false;
                    lblAppointmentID.Visible = true;
                    lblAppointmentID.Text = "Your Application ID is: " + appointmentID;
                    lblAppointmentID.ForeColor = System.Drawing.Color.Green;
                }
                
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PresentationLayer/PatientPage.aspx");
        }     
        
    }
}