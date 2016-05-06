using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DiagnosticCenter
{
    /// <summary>
    /// This DAL is used for inserting book appointment details into the database
    /// </summary>
    public class BookAppointmentDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataAdapter da1;
        DataSet ds;

        // Constructor for initialising the Sql Sever Connection
        public BookAppointmentDAL(string conString)
        {
            con = new SqlConnection(conString);
            con.Open();
        }

        //This method inserts the appointment details entered by the patient
        public string BookAppDAL(string username,string name,string gender,string serviceType, string date, string reason)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BookAppDetails", con);              //Stored Procedure to book appointment
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@PatientName", name);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@ServiceType", serviceType);
                cmd.Parameters.AddWithValue("@AppointmentDate", date);
                cmd.Parameters.AddWithValue("@RFV", reason);
                cmd.Parameters.AddWithValue("@Status", "Pending");
                da = new SqlDataAdapter();
                ds = new DataSet();
                da.InsertCommand = cmd;
                da.InsertCommand.ExecuteNonQuery();
                SqlCommand newcmd = new SqlCommand("select Max(AppointmentID) from BookAppointment", con);
                da = new SqlDataAdapter();
                da.SelectCommand = newcmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.Rows[0];
                string appointmentID = dr[0].ToString();
                return appointmentID;
            }
            catch (Exception)
            {
                return "Already Exist";
            }
        }

        public DataTable RetrieveData(string username)
        {
            SqlCommand cmd = new SqlCommand("GetPatientDetails", con);              /*Stored Procedure to insert the user details into User Registration Table*/
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", username);
            da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            
        }

        public DataTable RetrieveDataStaff(string username)
        {
            SqlCommand cmd = new SqlCommand("GetStaffDetails", con);              /*Stored Procedure to insert the user details into User Registration Table*/
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", username);
            da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;

        }
    }
}