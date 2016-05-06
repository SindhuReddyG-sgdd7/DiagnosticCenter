using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace DiagnosticCenter
{
    public class UpdateorRemoveStaffBLL
    {
        ConnectionStringLayer csLayer;
        public bool UpdateStaffBLL(string username, string firstname, string phoneno, string email, string city, string pincode)        
        {
            csLayer = new ConnectionStringLayer();              /*Connection String which is accessed from Connection string layer*/
            string conString = csLayer.cs;
            UpdateorRemoveStaffDAL update = new UpdateorRemoveStaffDAL(conString);
            bool updated = update.UpdateStaffDAL(username,firstname,phoneno,email,city,pincode);
            return updated;
            
        }

        public bool RemoveStaffBLL(string username)
        {
            csLayer = new ConnectionStringLayer();              /*Connection String which is accessed from Connection string layer*/
            string conString = csLayer.cs;
            UpdateorRemoveStaffDAL remove = new UpdateorRemoveStaffDAL(conString);
            bool updated = remove.RemoveStaffDAL(username);
            return updated;
            
        }
    }
}