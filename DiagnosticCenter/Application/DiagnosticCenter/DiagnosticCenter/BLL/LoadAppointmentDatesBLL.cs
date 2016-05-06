using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DiagnosticCenter
{
    public class LoadAppointmentDatesBLL
    {
        ConnectionStringLayer csLayer;
        public DataTable LoadDate()
        {
            csLayer = new ConnectionStringLayer();              /*Connection String which is accessed from Connection string layer*/
            string conString = csLayer.cs;
            LoadAppointmentDatesDAL loadDAL = new LoadAppointmentDatesDAL(conString);
            DataTable dt = loadDAL.LoadDate();
            return dt;
           
        }

        public DataTable LoadGrid(string appointmentDate)
        {
            csLayer = new ConnectionStringLayer();              /*Connection String which is accessed from Connection string layer*/
            string conString = csLayer.cs;
            LoadAppointmentDatesDAL loadDAL = new LoadAppointmentDatesDAL(conString);
            DataTable dt = loadDAL.LoadGrid(appointmentDate);
            return dt;
        }
    }
    
}
