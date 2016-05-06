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
    /// This DAL is used for the user authentication and authorization
    /// </summary>
    public class UserAuthenticationDAL
    {             
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataAdapter da1;
        DataSet ds;
        // Constructor for initialising the Sql Sever Connection

        public UserAuthenticationDAL(string conString)
        {
            con = new SqlConnection(conString);
            con.Open();
        }
        // This method authenticates the user based on credentials entered

        public string UserAuthentication(string userName, string hashedPwd)
        {
            SqlCommand cmd = new SqlCommand("RetrieveSalt", con);              
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", userName);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            string saltPwd= (string) da.SelectCommand.ExecuteScalar();
            string netPwd = hashedPwd+saltPwd;
            string newhashed = FormsAuthentication.HashPasswordForStoringInConfigFile(netPwd, "MD5");
            SqlCommand newcmd = new SqlCommand("UserDetails", con);              
            newcmd.CommandType = System.Data.CommandType.StoredProcedure;
            newcmd.Parameters.AddWithValue("@UserName", userName);
            newcmd.Parameters.AddWithValue("@UserPwd", newhashed);
            da1 = new SqlDataAdapter();
            da1.SelectCommand = newcmd;
            string userRole = (string)da1.SelectCommand.ExecuteScalar();
            return userRole;
            
        }

        // This method authenticates manager
        public bool ManagerAuthentication(string UserName, string UserPwd)
        {
            string newhashed = FormsAuthentication.HashPasswordForStoringInConfigFile(UserPwd, "MD5");
            SqlCommand cmd = new SqlCommand("MangerPwd", con);              
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", UserName);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            string managerPwd = (string)da.SelectCommand.ExecuteScalar();
            if (managerPwd == newhashed)
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