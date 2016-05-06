using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiagnosticCenter;
using System.Data;

namespace DiagnosticCentre
{
    public partial class PatientRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblReg.Visible = false;
            lblPwd.Visible = false;
            lblUserName.Visible = false;
            lblUser.Visible = false;
            lblPassword.Visible = false;
            lblExist.Visible = false;
            //RangeValidator1.MaximumValue = DateTime.UtcNow.AddYears(-5).ToShortDateString();
            //RangeValidator1.MinimumValue = DateTime.Today.AddYears(-70).ToShortDateString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                PatientRegistrationBLL regBLL = new PatientRegistrationBLL();
                string gender = RadioButtonListGender.SelectedValue;
                string[] credentials = new string[2];
                credentials = regBLL.RegisterDetailsBLL(TxtFN.Text, TxtLN.Text, gender, TxtDOB.Text, TxtAge.Text, TxtMobile.Text, TxtEmail.Text, TxtAddress.Text, TxtCity.Text, TxtPin.Text);
                if (credentials[0] == "Already Exist")
                {
                    lblExist.Visible = true;
                    lblExist.Text = credentials[0];
                }
                else
                {
                    lblReg.Visible = true;
                    patientReg.Visible = false;
                    lblTitle.Visible = false;
                    lblPwd.Visible = true;
                    lblUserName.Visible = true;
                    lblUser.Visible = true;
                    lblPassword.Visible = true;
                    lblPwd.Text = credentials[1];
                    lblUserName.Text = credentials[0];
                    lblPwd.ForeColor = System.Drawing.Color.Green;
                    lblUserName.ForeColor = System.Drawing.Color.Green;
                }
            }
        }
    }
}