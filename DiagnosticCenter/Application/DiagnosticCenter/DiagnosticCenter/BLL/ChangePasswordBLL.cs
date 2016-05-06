using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;

namespace DiagnosticCenter
{
    public class ChangePasswordBLL
    {
        ConnectionStringLayer csLayer;
        public bool ChangePasswordStaff(string username,string oldPwd, string newPwd)
        {
            csLayer = new ConnectionStringLayer();              /*Connection String which is accessed from Connection string layer*/
            string conString = csLayer.cs;   
            ChangePasswordDAL changePwd = new ChangePasswordDAL(conString);
            bool changed = changePwd.ChangePasswordStaff(username,oldPwd, newPwd);
            return changed;
            
        }

        public bool ChangePasswordPatient(string username, string oldPwd, string newPwd)
        {
            csLayer = new ConnectionStringLayer();              /*Connection String which is accessed from Connection string layer*/
            string conString = csLayer.cs;
            ChangePasswordDAL changePwd = new ChangePasswordDAL(conString);
            bool changed = changePwd.ChangePasswordPatient(username,oldPwd, newPwd);
            return changed;
           
        }
    }
}