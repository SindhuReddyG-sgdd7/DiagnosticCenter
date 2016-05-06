using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DiagnosticCenter
{
    public class AddPatientDetailsBLL
    {
        ConnectionStringLayer csLayer;
        public bool AddPatient(string username, string name, string gender, string age, string servicetype, string refferedDoctor)
        {
            csLayer = new ConnectionStringLayer();              /*Connection String which is accessed from Connection string layer*/
            string conString = csLayer.cs;
            AddPatientDetailsDAL regDAL = new AddPatientDetailsDAL(conString);
            bool inserted = regDAL.AddPatient(username, name, gender,age, servicetype, refferedDoctor);
            return inserted;
            
        }
    }
}