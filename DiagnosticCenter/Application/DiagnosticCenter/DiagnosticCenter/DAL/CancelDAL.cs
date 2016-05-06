using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DiagnosticCenter
{
    /// <summary>
    /// This is used for cancelling appointment date booked by the patient
    /// </summary>
    public class CancelDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataAdapter da1;
        DataSet ds;

        // Constructor for initialising the Sql Sever Connection
        public CancelDAL(string conString)
        {
            con = new SqlConnection(conString);
            con.Open();
        }

        // This method cancels the appointment date
        public DataTable SearchAppDAL(string name, string AppID)
        {
            SqlCommand cmd = new SqlCommand("SearchAppointmentId", con); //Stored Procedure to search the appointment date
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", name);
            cmd.Parameters.AddWithValue("@AppointmentID", AppID);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool CancelAppDAL(string name, string AppID)
        {
            SqlCommand cmd = new SqlCommand("RemoveAppointmentID", con);//Stored Procedure to cancel the appointment date
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", name);
            cmd.Parameters.AddWithValue("@AppointmentID", AppID);
            SqlDataAdapter ada = new SqlDataAdapter();
            SqlDataAdapter da = new SqlDataAdapter();
            da.DeleteCommand = cmd;
            int rowsDeleted = da.DeleteCommand.ExecuteNonQuery();
            if (rowsDeleted == 1)
                return true;
            else
                return false;
        }
    }
}