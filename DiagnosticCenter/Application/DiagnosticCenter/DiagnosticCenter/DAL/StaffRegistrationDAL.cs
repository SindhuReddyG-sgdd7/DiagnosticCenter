using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DiagnosticCenter
{
    /// <summary>
    /// This DAL is used for registration of staff
    /// </summary>
    public class StaffRegistrationDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataAdapter da1;
        DataSet ds;
        // Constructor for initialising the Sql Sever Connection

        public StaffRegistrationDAL(string conString)
        {
            con = new SqlConnection(conString);
            con.Open();
        }
        // This method inserts the staff details into the database

        public string[] RegisterDetailsDAL(string firstName, string lastName, string gender, string dob, string age, string phoneNo, string email, string qualification, string experience, string address, string city, string pincode)
        {
            try
            {
                int Age = DateTime.Now.Year - Convert.ToDateTime(dob).Year;
                Random randomUser = new Random();
                Random randomPwd = new Random();
                string UserID = firstName.Substring(0, 1) + lastName.Substring(0, 1) + randomUser.Next(1000, 2000).ToString();
                string UserPwd = "$" + firstName.Substring(0, 1) + lastName.Substring(0, 1) + randomPwd.Next(1000, 10000).ToString();
                EncodePasswordBLL encodePwd = new EncodePasswordBLL();
                string hashedPwd = encodePwd.HashandSalt(UserID, UserPwd);
                SqlCommand cmd = new SqlCommand("StaffRegDetails", con);              //Stored Procedure to insert the staff details
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", UserID);
                cmd.Parameters.AddWithValue("@UserPwd", hashedPwd);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(dob));
                cmd.Parameters.AddWithValue("@Age", Age);
                cmd.Parameters.AddWithValue("@PhoneNo", phoneNo);
                cmd.Parameters.AddWithValue("@EMail", email);
                cmd.Parameters.AddWithValue("@Qualification", qualification);
                cmd.Parameters.AddWithValue("@Experience", Convert.ToInt32(experience));
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@PIN", pincode);
                da = new SqlDataAdapter();
                ds = new DataSet();
                da.InsertCommand = cmd;
                da.InsertCommand.ExecuteNonQuery();
                string[] credentials = new string[2];
                credentials[0] = UserID;
                credentials[1] = UserPwd;
                return credentials;
            }
            catch (Exception)
            {
                string[] credentials = new string[2];
                credentials[0] = "Already Exist";
                return credentials;
            }

        }
    }
}