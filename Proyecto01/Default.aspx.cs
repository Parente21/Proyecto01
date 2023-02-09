using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto01
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                BDConexion.Conexion.abrir();
                SqlCommand cmd = new SqlCommand("C_encuestas_select", BDConexion.Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@encuesta_id", 1);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);

                StringBuilder tbl = new StringBuilder();
                tbl.Append("<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:Arial'>");
                tbl.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    tbl.Append("<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + column.ColumnName + "</th>");
                }
                tbl.Append("</tr>");

                foreach (DataRow row in dt.Rows)
                {
                    tbl.Append("<tr>");
                    foreach (DataColumn column in dt.Columns)
                    {
                        tbl.Append("<td style='width:100px;border: 1px solid #ccc'>" + row[column.ColumnName].ToString() + "</td>");
                    }
                    tbl.Append("</tr>");
                }

                //Table end.
                tbl.Append("</table>");
                ltTable.Text = tbl.ToString();
            }

        }
    }
}