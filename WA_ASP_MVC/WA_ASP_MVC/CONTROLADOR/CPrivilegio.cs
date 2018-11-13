using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WA_ASP_MVC.CONTROLADOR
{
    public class CPrivilegio
    {
        SqlConnection cnn = new SqlConnection("Data Source=(local);DataBase=bdnotas;user='sa';pwd='whoami'");
        DataTable dT = new DataTable();

        public DataTable listarPrivilegio()
        {
            using (SqlDataAdapter dA = new SqlDataAdapter("sp_ListarPrivilegio", cnn))
            {
                dA.SelectCommand.CommandType = CommandType.StoredProcedure;
                dA.Fill(dT);
            }
            return dT;
        }
    }
}