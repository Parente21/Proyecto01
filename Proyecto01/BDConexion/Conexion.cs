using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Proyecto01.BDConexion
{
    public class Conexion
    {
        public static string conexion = System.Web.HttpContext.Current.Application["conexiones"].ToString();
        public static SqlConnection conectar = new SqlConnection(conexion);

        public static void abrir()
        {
            if(conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }
        public static void cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}