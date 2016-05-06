using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DiagnosticCenter
{
    public class ViewStaffDetailsBLL
    {
        ConnectionStringLayer csLayer;
        public DataTable ViewStaff()
        {
            csLayer = new ConnectionStringLayer();              /*Connection String which is accessed from Connection string layer*/
            string conString = csLayer.cs;
            ViewStaffDetailsDAL viewDetails = new ViewStaffDetailsDAL(conString);
            DataTable dt = viewDetails.ViewStaff();
            return dt;
            
        }
    }
}