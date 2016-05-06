using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiagnosticCenter
{
    public class ApplicationStatusBLL
    {
        ConnectionStringLayer csLayer;
        public string AppStatusBLL(string name,string AppID)
        {
            csLayer = new ConnectionStringLayer(); 
            string conString = csLayer.cs;
            ApplicationStatusDAL Status = new ApplicationStatusDAL(conString);
            string status = Status.AppStatusDAL(name,AppID);
            return status;
        }
    }
}