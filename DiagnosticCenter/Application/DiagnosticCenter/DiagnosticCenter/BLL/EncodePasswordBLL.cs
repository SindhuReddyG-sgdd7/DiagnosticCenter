using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace DiagnosticCenter
{
    public class EncodePasswordBLL
    {
        ConnectionStringLayer csLayer;
        public string HashandSalt(string UserName,string UserPwd)
        {
            csLayer = new ConnectionStringLayer();              /*Connection String which is accessed from Connection string layer*/
            string conString = csLayer.cs;
            string hashedPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(UserPwd, "MD5");
            Random randomNumber = new Random();
            int randomnumber = randomNumber.Next(10000, 20000);
            string saltedPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(randomnumber.ToString(), "MD5");
            EncodePasswordDAL storeSalt = new EncodePasswordDAL(conString);
            bool inserted = storeSalt.SaltedPwd(UserName,saltedPwd);
            string newhashed = FormsAuthentication.HashPasswordForStoringInConfigFile(hashedPwd + saltedPwd, "MD5");
            if (inserted)
            {
                return newhashed;
            }
            else
            {
                return "Not";
            }
        }
    }
}