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
    /// This DAL is used for changing user password
    /// </summary>
    public class ChangePasswordDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataAdapter da1;
        DataSet ds;

        // Constructor for initialising the Sql Sever Connection
        public ChangePasswordDAL(string conString)
        {
            con = new SqlConnection(conString);
            con.Open();
        }

        // This method is used for changing the staff password after login
        public bool ChangePasswordStaff(string username, string oldPwd, string newPwd)
        {
            string hashedPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(oldPwd, "MD5");
            SqlCommand newcmd = new SqlCommand("RetrieveSalt", con);
            newcmd.CommandType = System.Data.CommandType.StoredProcedure;
            newcmd.Parameters.AddWithValue("@UserName", username);
            da = new SqlDataAdapter();
            da.SelectCommand = newcmd;
            string saltedPwd = (string)da.SelectCommand.ExecuteScalar();
            string newhashedPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(hashedPwd + saltedPwd, "MD5");

            string newhashedPwd1 = FormsAuthentication.HashPasswordForStoringInConfigFile(newPwd, "MD5");
            Random randomNumber = new Random();
            int randomnumber = randomNumber.Next(10000, 20000);
            string newsaltedPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(randomnumber.ToString(), "MD5");
            string newhashedPwd2 = FormsAuthentication.HashPasswordForStoringInConfigFile(newhashedPwd1 + newsaltedPwd, "MD5");

            
            SqlCommand cmd = new SqlCommand("ChangePasswordStaff", con);              
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OldPwd", newhashedPwd);
            cmd.Parameters.AddWithValue("@NewPwd", newhashedPwd2);
            da = new SqlDataAdapter();
            ds = new DataSet();
            da.UpdateCommand = cmd;
            int rowsUpdated = da.UpdateCommand.ExecuteNonQuery();
            if (rowsUpdated == 1)
            {
                UpdateLoginPasswordBLL updatePwd = new UpdateLoginPasswordBLL();
                updatePwd.UpdatePassword(username, oldPwd, newhashedPwd2);
                SqlCommand cmd1 = new SqlCommand("UpdateSalt", con);
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@UserName", username);
                cmd1.Parameters.AddWithValue("@UserPwd", newsaltedPwd);
                da1 = new SqlDataAdapter();
                ds = new DataSet();
                da1.UpdateCommand = cmd1;
                int rowsUpdated1 = da1.UpdateCommand.ExecuteNonQuery();
                return true;
            }
            else
            {
                return false;
            }
           

            
        }

        // This method is used for changing the patient password after login
        public bool ChangePasswordPatient(string username,string oldPwd, string newPwd)
        {
            string hashedPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(oldPwd, "MD5");
            SqlCommand newcmd = new SqlCommand("RetrieveSalt", con);
            newcmd.CommandType = System.Data.CommandType.StoredProcedure;
            newcmd.Parameters.AddWithValue("@UserName", username);
            da = new SqlDataAdapter();
            da.SelectCommand = newcmd;
            string saltedPwd = (string)da.SelectCommand.ExecuteScalar();
            string newhashedPwd = FormsAuthentication.HashPasswordForStoringInConfigFile( hashedPwd+saltedPwd , "MD5");

            string newhashedPwd1 = FormsAuthentication.HashPasswordForStoringInConfigFile(newPwd, "MD5");
            Random randomNumber = new Random();
            int randomnumber = randomNumber.Next(10000, 20000);
            string newsaltedPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(randomnumber.ToString(), "MD5");
            string newhashedPwd2 = FormsAuthentication.HashPasswordForStoringInConfigFile(newhashedPwd1 + newsaltedPwd, "MD5");

            SqlCommand cmd = new SqlCommand("ChangePasswordPatient", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OldPwd", newhashedPwd);
            cmd.Parameters.AddWithValue("@NewPwd", newhashedPwd2);
            da = new SqlDataAdapter();
            ds = new DataSet();
            da.UpdateCommand = cmd;
            int rowsUpdated = da.UpdateCommand.ExecuteNonQuery();
            if (rowsUpdated == 1)
            {
                UpdateLoginPasswordBLL updatePwd = new UpdateLoginPasswordBLL();
                updatePwd.UpdatePassword(username, oldPwd, newhashedPwd2);
                SqlCommand cmd2 = new SqlCommand("UpdateSalt", con);
                cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@UserName", username);
                cmd2.Parameters.AddWithValue("@UserPwd", newsaltedPwd);
                da1 = new SqlDataAdapter();
                ds = new DataSet();
                da1.UpdateCommand = cmd2;
                da1.UpdateCommand.ExecuteNonQuery();
                return true;
            }
            else
            {
                return false;
            }
       

        }  
    }
}