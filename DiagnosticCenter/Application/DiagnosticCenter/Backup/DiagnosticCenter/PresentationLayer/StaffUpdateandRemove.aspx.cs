using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiagnosticCenter
{
    public partial class WebForm8 : System.Web.UI.Page
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
                    txtName.Text = Request.QueryString["FirstName"];
                    txtUserName.Text = Request.QueryString["UserName"];
                    txtPhoneNo.Text = Request.QueryString["PhoneNo"];
                    txtEmail.Text = Request.QueryString["Email"];
                    txtCity.Text = Request.QueryString["City"];
                    txtPinCode.Text = Request.QueryString["Pincode"];
                    lblUpdate.Visible = false;
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string name = Request.QueryString["FirstName"];
                string userName = Request.QueryString["UserName"];
                UpdateorRemoveStaffBLL update = new UpdateorRemoveStaffBLL();
                bool updated = update.UpdateStaffBLL(userName, name, txtPhoneNo.Text, txtEmail.Text, txtCity.Text, txtPinCode.Text);
                lblUpdate.Visible = true;
                if (updated)
                {
                    lblUpdate.Text = "Updated Successfully";
                    lblUpdate.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblUpdate.Text = "Not Updated Successfully";
                    lblUpdate.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                UpdateorRemoveStaffBLL remove = new UpdateorRemoveStaffBLL();
                bool removed = remove.RemoveStaffBLL(txtUserName.Text);
                lblUpdate.Visible = true;
                if (removed)
                {
                    lblUpdate.Text = "Staff Removed Successfully";
                    lblUpdate.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblUpdate.Text = "Staff Not Removed Successfully";
                    lblUpdate.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}