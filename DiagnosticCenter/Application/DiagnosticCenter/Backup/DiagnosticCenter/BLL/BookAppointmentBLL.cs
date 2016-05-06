using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace DiagnosticCenter
{
    public class BookAppointmentBLL
    {
        ConnectionStringLayer csLayer;
        public string BookAppBLL(string username,string name,string gender,string serviceType,string date, string reason)
        {
            csLayer = new ConnectionStringLayer();
            string conString = csLayer.cs;
            BookAppointmentDAL BookDAL = new BookAppointmentDAL(conString);
            string appointmentID = BookDAL.BookAppDAL(username,name, gender, serviceType, date, reason);
            return appointmentID;
        }
        public DataTable RetrieveData(string username)
        {
            csLayer = new ConnectionStringLayer();
            string conString = csLayer.cs;
            BookAppointmentDAL retrieve = new BookAppointmentDAL(conString);
            DataTable dt = retrieve.RetrieveData(username);
            return dt;
        }
        public DataTable RetrieveDataStaff(string username)
        {
            csLayer = new ConnectionStringLayer();
            string conString = csLayer.cs;
            BookAppointmentDAL retrieve = new BookAppointmentDAL(conString);
            DataTable dt = retrieve.RetrieveDataStaff(username);
            return dt;
        }    
    }
}