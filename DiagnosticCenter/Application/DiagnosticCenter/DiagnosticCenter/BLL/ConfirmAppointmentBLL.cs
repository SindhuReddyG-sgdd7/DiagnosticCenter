using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DiagnosticCenter
{
    public class ConfirmAppointmentBLL
    {
        ConnectionStringLayer csLayer;
        public void ConfirmAppointment(string appointmentDate)
        {
            csLayer = new ConnectionStringLayer();              /*Connection String which is accessed from Connection string layer*/
            string conString = csLayer.cs;
            ConfirmAppointmenDAL confirm = new ConfirmAppointmenDAL(conString);
            confirm.ConfirmAppointment(appointmentDate);
          
        }
    }
}