using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace DiagnosticCenter
{
    public class UserAuthenticationBLL
    {
        ConnectionStringLayer csLayer;
        public string UserAuthentication(string UserName,string UserPwd)
        {
            csLayer = new ConnectionStringLayer();              /*Connection String which is accessed from Connection string layer*/
            string conString = csLayer.cs;
            string hashedPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(UserPwd, "MD5");
            if (UserName == "MID1212")
            {

                UserAuthenticationDAL managerAuth = new UserAuthenticationDAL(conString);
                bool authenticated = managerAuth.ManagerAuthentication(UserName,UserPwd);
                if (authenticated)
                {
                    return "Manager";
                }
                else
                {
                    return "Not";
                }
            }
            else
            {
                UserAuthenticationDAL regDAL = new UserAuthenticationDAL(conString);
                string userRole = regDAL.UserAuthentication(UserName, hashedPwd);
                return userRole;
               
            }
        }
    }
    
}