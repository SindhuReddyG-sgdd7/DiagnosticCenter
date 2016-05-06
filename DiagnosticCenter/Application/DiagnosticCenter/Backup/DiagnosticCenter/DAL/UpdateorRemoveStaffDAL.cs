using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DiagnosticCenter
{
    /// <summary>
    /// This method is used for either updating or removing staff details
    /// </summary>
    public class UpdateorRemoveStaffDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataAdapter da1;
        DataSet ds;
        // Constructor for initialising the Sql Sever Connection

        public UpdateorRemoveStaffDAL(string conString)
        {
            con = new SqlConnection(conString);
            con.Open();
        }
        // This method updates the staff details

        public bool UpdateStaffDAL(string username,string firstname,string phoneno,string email,string city,string pincode)
        {
            SqlCommand cmd = new SqlCommand("UpdateStaff", con);              //Stored Procedure to update staff details
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@PhoneNo", phoneno);
            cmd.Parameters.AddWithValue("@EMail", email);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@Pincode", pincode);
            da = new SqlDataAdapter();
            ds = new DataSet();
            da.UpdateCommand = cmd;
            da.UpdateCommand.ExecuteNonQuery();
            return true;
            
        }

        // This method removes the staff details from the database
        public bool RemoveStaffDAL(string username)
        {
            SqlCommand cmd = new SqlCommand("RemoveStaff", con);              //Stored Procedure to remove the staff details
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", username);
            da = new SqlDataAdapter();
            ds = new DataSet();
            da.DeleteCommand = cmd;
            da.DeleteCommand.ExecuteNonQuery();
            return true;

        }  
    }
}