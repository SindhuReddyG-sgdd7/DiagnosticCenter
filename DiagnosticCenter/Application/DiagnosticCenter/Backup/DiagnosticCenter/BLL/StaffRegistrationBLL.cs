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
    public class StaffRegistrationBLL
    {
        ConnectionStringLayer csLayer;
        public string[] RegisterDetailsBLL(string firstName,string lastName,string gender,string dob,string age,string phoneNo,string email,string qualification,string experience,string address,string city,string pincode)
        {
            csLayer = new ConnectionStringLayer();              /*Connection String which is accessed from Connection string layer*/
            string conString = csLayer.cs;
            StaffRegistrationDAL regDAL = new StaffRegistrationDAL(conString);
            string[] credentials = new string[2];
            credentials = regDAL.RegisterDetailsDAL(firstName,lastName,gender,dob,age,phoneNo,email,qualification,experience,address,city,pincode);
            return credentials;
            
        }
    }
}