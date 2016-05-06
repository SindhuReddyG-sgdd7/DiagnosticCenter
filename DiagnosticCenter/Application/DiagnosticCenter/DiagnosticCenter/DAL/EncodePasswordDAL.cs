using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DiagnosticCenter
{
    /// <summary>
    /// This DAL is used for hashing and salting the password entered by the user
    /// </summary>
    public class EncodePasswordDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataAdapter da1;
        DataSet ds;

        // This method initializes the sql connection
        public EncodePasswordDAL(string conString)
        {
            con = new SqlConnection(conString);
            con.Open();
        }

        // This method insert the password salt into a database table
        public bool SaltedPwd(string username, string saltedPwd)
        {
            SqlCommand cmd = new SqlCommand("InsertUserSalt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@SaltedPwd", saltedPwd);
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = cmd;
            int rowsInserted = da.InsertCommand.ExecuteNonQuery();
            if (rowsInserted == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}