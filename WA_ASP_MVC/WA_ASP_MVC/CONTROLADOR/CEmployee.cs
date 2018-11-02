using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WA_ASP_MVC.CONTROLADOR
{
    public class CEmployee
    {
        SqlConnection cnn = new SqlConnection("Data Source=(local);DataBase=Northwind;user='sa';pwd='whoami'");

        DataTable dT = new DataTable();

        public DataTable ListarEmployees()
        {
            using (SqlDataAdapter dA = new SqlDataAdapter("sp_ListEmpleados", cnn))
            {
                dA.SelectCommand.CommandType = CommandType.StoredProcedure;
                dA.Fill(dT);
            }
            cnn.Close();
            return dT;
        }

        public DataTable ListaPedidosEmployee(string codigoEmployee)
        {
            using (SqlDataAdapter dA = new SqlDataAdapter("ListaPedidosEmployee", cnn))
            {
                dA.SelectCommand.CommandType = CommandType.StoredProcedure;
                dA.SelectCommand.Parameters.AddWithValue("@EmployeeID", codigoEmployee.ToString());
                dA.Fill(dT);
            }
            cnn.Close();
            return dT;
        }

    }
}