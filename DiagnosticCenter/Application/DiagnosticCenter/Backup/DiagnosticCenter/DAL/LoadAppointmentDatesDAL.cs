using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace DiagnosticCenter
{
    /// <summary>
    /// This method is used for loading the appointment details into the dropdown list
    /// </summary>
    public class LoadAppointmentDatesDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataAdapter da1;
        DataSet ds;
        // Constructor for initialising the Sql Sever Connection

        public LoadAppointmentDatesDAL(string conString)
        {
            con = new SqlConnection(conString);
            con.Open();
        }
        // This method loads appointmentdates

        public DataTable LoadDate()
        {

            SqlCommand cmd = new SqlCommand("select distinct AppointmentDate from BookAppointment", con);              
            cmd.CommandType = System.Data.CommandType.Text;
            da = new SqlDataAdapter();
            ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
            
        }

        // This method is used for loading the selected date patient detials into the GridView
        public DataTable LoadGrid(string appointmentDate)
        {

            SqlCommand cmd = new SqlCommand("select * from BookAppointment where AppointmentDate=@AppointmentDate", con);              
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@AppointmentDate", Convert.ToDateTime(appointmentDate));
            da = new SqlDataAdapter();
            ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;

        }  
    }
}