using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace DiagnosticCenter
{
    /// <summary>
    /// This DAL is used for inserting patient details added by the staff into the database
    /// </summary>
    public class AddPatientDetailsDAL
    {
         
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataAdapter da1;
        DataSet ds;
        //Constructor for initialising the Sql Sever Connection

        public AddPatientDetailsDAL(string conString)
        {
            con = new SqlConnection(conString);
            con.Open();
        }
        //This method inserts patient details entered by the staff

        public bool AddPatient(string username, string name, string gender, string age, string servicetype, string refferedDoctor)
        {
            SqlCommand cmd = new SqlCommand("AddPatientDetails", con);              //Stored Procedure to insert the patient details
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@PatientName", name);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@PatientAge", age);
            cmd.Parameters.AddWithValue("@TestType", servicetype);
            cmd.Parameters.AddWithValue("@ReferredDoctor", refferedDoctor);
            da = new SqlDataAdapter();
            ds = new DataSet();
            da.InsertCommand = cmd;
            int rowsInserted = da.InsertCommand.ExecuteNonQuery();
            if (rowsInserted == 1)
                return true;
            else
                return false;
            
        }  
    }
}