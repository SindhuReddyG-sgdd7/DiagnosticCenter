using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DiagnosticCenter
{
    /// <summary>
    /// This DAL is used for knowing the status of the appointment made by the patient
    /// </summary>
    public class ApplicationStatusDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataAdapter da1;
        DataSet ds;

        // This Constructor initializes SQL connection with the server
        public ApplicationStatusDAL(string conString)
        {
            con = new SqlConnection(conString);
            con.Open();
        }

        // This method gives the status informatin for a particular appointment ID
        public string AppStatusDAL(string name, string AppID)
        {
            SqlCommand cmd = new SqlCommand("select Status from BookAppointment where AppointmentID = '" + AppID + "' and UserName = '" + name + "'", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            SqlDataReader dr1 = cmd.ExecuteReader();
            string status;
            while (dr1.Read())
            {
                status = (string) dr1["Status"];
                return status;
            }
            return ""; 
        }

        
    }
}