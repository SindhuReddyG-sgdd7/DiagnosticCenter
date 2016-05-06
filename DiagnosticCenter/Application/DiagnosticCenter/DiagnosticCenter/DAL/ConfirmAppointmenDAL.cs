using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace DiagnosticCenter
{
    /// <summary>
    /// This DAL is use for confirming the appointment request made by the patient
    /// </summary>
    public class ConfirmAppointmenDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataAdapter da1;
        DataSet ds;
        // Constructor for initialising the Sql Sever Connection

        public ConfirmAppointmenDAL(string conString)
        {
            con = new SqlConnection(conString);
            con.Open();
        }
        // This method is used for confirming the requests of the patient by the manager

        public void ConfirmAppointment(string appointmentDate)
        {

            SqlCommand cmd = new SqlCommand("UpdateStatus", con);              //Stored Procedure to update the status of the patient
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
            da = new SqlDataAdapter();
            ds = new DataSet();
            da.UpdateCommand = cmd;
            da.UpdateCommand.ExecuteNonQuery();
        }
    }
}