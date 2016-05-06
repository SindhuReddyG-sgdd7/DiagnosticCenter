using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;

namespace DiagnosticCenter
{
    public class UpdateLoginPasswordBLL
    {
        ConnectionStringLayer csLayer;
        public void UpdatePassword(string username,string oldPwd, string newpwd)
        {
            csLayer = new ConnectionStringLayer();              /*Connection String which is accessed from Connection string layer*/
            string conString = csLayer.cs;
            string hashedPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(oldPwd, "MD5");
            UpdateLoginPasswordDAL updateLoginPwd = new UpdateLoginPasswordDAL(conString);
            updateLoginPwd.UpdatePassword(username, hashedPwd, newpwd);
     
           
        }

        public bool UpdateManagerPassword(string username, string oldPwd, string newpwd)
        {
            csLayer = new ConnectionStringLayer();              /*Connection String which is accessed from Connection string layer*/
            string conString = csLayer.cs;
            string hashedPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(oldPwd, "MD5");
            UpdateLoginPasswordDAL updateLoginPwd = new UpdateLoginPasswordDAL(conString);
            bool updated = updateLoginPwd.UpdateManagerPassword(username, hashedPwd, newpwd);
            return updated;
           
        }

    }
}