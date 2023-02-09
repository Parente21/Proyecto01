using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Proyecto01
{
    public class Global : HttpApplication
    {
        public void LlenaConexion()
        {
            string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["bdConexion"].ToString();
            Application["conexiones"] = conexion;
        }
        void Application_Start(object sender, EventArgs e)
        {
            LlenaConexion();
        }
    }
}