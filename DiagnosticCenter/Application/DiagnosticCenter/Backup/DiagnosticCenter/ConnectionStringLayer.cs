using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace DiagnosticCenter
{
    class ConnectionStringLayer
    {
            public string cs = ConfigurationManager.ConnectionStrings["DCCS"].ConnectionString.ToString();
    }
}