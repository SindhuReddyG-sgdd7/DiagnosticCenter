using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DiagnosticCenter
{
    public class PatientRegistrationBLL
    {
        ConnectionStringLayer csLayer;
        public string[] RegisterDetailsBLL(string firstName,string lastName,string gender,string dob,string age,string phoneNo,string email,string address,string city,string pincode)
        {
            csLayer = new ConnectionStringLayer();              /*Connection String which is accessed from Connection string layer*/
            string conString = csLayer.cs;
            PatientRegistrationDAL regDAL = new PatientRegistrationDAL(conString);
            string[] credentials = new string[2];
            credentials = regDAL.RegisterDetailsDAL(firstName, lastName, gender, dob, age, phoneNo, email, address, city, pincode);
            return credentials;
            
        }
    }
}