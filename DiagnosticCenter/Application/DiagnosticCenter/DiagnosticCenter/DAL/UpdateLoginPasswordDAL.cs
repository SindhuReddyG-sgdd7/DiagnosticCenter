using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;

namespace DiagnosticCenter
{
    /// <summary>
    /// This method is used for updating login password
    /// </summary>
    public class UpdateLoginPasswordDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        // Constructor for initialising the Sql Sever Connection

        public UpdateLoginPasswordDAL(string conString)
        {
            con = new SqlConnection(conString);
            con.Open();
        }
        // This method updates the user password

        public void UpdatePassword(string userName,string hashedPwd, string newPwd)
        {
            SqlCommand newcmd = new SqlCommand("RetrieveSalt", con);
            newcmd.CommandType = System.Data.CommandType.StoredProcedure;
            newcmd.Parameters.AddWithValue("@UserName", userName);
            da = new SqlDataAdapter();
            da.SelectCommand = newcmd;
            string saltedPwd = (string)da.SelectCommand.ExecuteScalar();
            string newhashedPwd = FormsAuthentication.HashPasswordForStoringInConfigFile( hashedPwd+saltedPwd , "MD5");

            SqlCommand cmd = new SqlCommand("UpdatePassword", con);              //Stored Procedure to update the password
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OldPwd", newhashedPwd);
            cmd.Parameters.AddWithValue("@NewPwd", newPwd);
            da = new SqlDataAdapter();
            ds = new DataSet();
            da.UpdateCommand = cmd;
            da.UpdateCommand.ExecuteNonQuery();
            
            
            
        }

        public bool UpdateManagerPassword(string userName, string hashedPwd, string newPwd)
        {
           
            string newhashedPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(newPwd, "MD5");

            SqlCommand cmd = new SqlCommand("UpdatePassword", con);              //Stored Procedure to update the password
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OldPwd", hashedPwd);
            cmd.Parameters.AddWithValue("@NewPwd", newhashedPwd);
            da = new SqlDataAdapter();
            ds = new DataSet();
            da.UpdateCommand = cmd;
            int rowsUpdated = da.UpdateCommand.ExecuteNonQuery();
            if (rowsUpdated == 1)
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