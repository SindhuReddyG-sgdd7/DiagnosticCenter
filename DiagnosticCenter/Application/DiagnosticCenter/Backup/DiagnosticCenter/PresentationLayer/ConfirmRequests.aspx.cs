using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DiagnosticCenter.PresentationLayer
{
    public partial class WebForm1 : System.Web.UI.Page
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
                    if ((string)Session["Role"] == "Staff")
                    {
                        Response.Redirect("~/PresentationLayer/StaffPage.aspx");
                    }
                    else if ((string)Session["Role"] == "Patient")
                    {
                        Response.Redirect("~/PresentationLayer/PatientPage.aspx");
                    }
                    else
                    {
                        LoadAppointmentDatesBLL loadDates = new LoadAppointmentDatesBLL();
                        DataTable dt = loadDates.LoadDate();
                        foreach (DataRow dr in dt.Rows)
                        {
                            ddlLoadDate.Items.Add(dr[0].ToString());
                        }
                        GridView1.Visible = false;
                        lblStatusGetDetails.Visible = false;
                        btnConfirm.Visible = false;
                        lblCnfrm.Visible = false;
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

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (ddlLoadDate.SelectedItem.Value == "-1")
            {
                lblStatusGetDetails.Visible = true;
                GridView1.Visible = false;
            }
            else
            {
                LoadAppointmentDatesBLL loadGrid = new LoadAppointmentDatesBLL();
                DataTable dt = loadGrid.LoadGrid(ddlLoadDate.SelectedValue.ToString());
                if (dt.Rows.Count == 0)
                {
                    GridView1.Visible = false;
                    lblStatusGetDetails.Visible = true;
                    lblStatusGetDetails.Text = "You have not selected appointment date";
                }
                else
                {
                    lblStatusGetDetails.Visible = false;
                    btnConfirm.Visible = true;
                    GridView1.Visible = true;
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            GridView1.PageIndex = e.NewPageIndex;
            LoadAppointmentDatesBLL loadGrid = new LoadAppointmentDatesBLL();
            DataTable dt = loadGrid.LoadGrid(ddlLoadDate.SelectedValue.ToString());
            if (dt.Rows.Count == 0)
            {
                GridView1.Visible = false;
                lblStatusGetDetails.Visible = true;
                lblStatusGetDetails.Text = "You have not selected appointment date";
            }
            else
            {
                lblStatusGetDetails.Visible = false;
                GridView1.Visible = true;
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ddlLoadDate.SelectedItem.Value == "-1")
            {
                lblStatusGetDetails.Visible = true;
                GridView1.Visible = false;
            }
            else
            {
                ConfirmAppointmentBLL confirm = new ConfirmAppointmentBLL();
                confirm.ConfirmAppointment(ddlLoadDate.SelectedValue.ToString());
                lblCnfrm.Visible = true;
                GridView1.Visible = false;
            }
        }
    }
}