using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


namespace DiagnosticCenter
{
    public class CancelBLL
    {
        ConnectionStringLayer csLayer;
        public DataTable SearchAppBLL(string name, string AppID)
        {
            csLayer = new ConnectionStringLayer();              /*Connection String which is accessed from Connection string layer*/
            string conString = csLayer.cs;
            CancelDAL canDAL = new CancelDAL(conString);
            DataTable dt = canDAL.SearchAppDAL(name, AppID);
            return dt;
        }
        public bool CancelAppBLL(string name, string AppID)
        {
            csLayer = new ConnectionStringLayer();              /*Connection String which is accessed from Connection string layer*/
            string conString = csLayer.cs;
            CancelDAL canDAL = new CancelDAL(conString);
            bool canceled = canDAL.CancelAppDAL(name, AppID);
            return canceled;
        }
    }
    
}