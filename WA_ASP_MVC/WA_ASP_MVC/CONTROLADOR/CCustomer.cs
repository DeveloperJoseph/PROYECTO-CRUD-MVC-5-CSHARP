using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WA_ASP_MVC.CONTROLADOR
{
    public class CCustomer
    {
        SqlConnection cnn = new SqlConnection("Data Source=(local);DataBase=Northwind;user='sa';pwd='whoami'");

        DataTable dT = new DataTable();
       
        public DataTable ListaCustomers()
        {
            using (SqlDataAdapter dA = new SqlDataAdapter("sp_ListCustomers", cnn))
            {
                dA.SelectCommand.CommandType = CommandType.StoredProcedure;
                dA.Fill(dT);
            }

            return dT;
        }


        public DataTable ListaPedidos(string codigoCliente)
        {

            using ( SqlDataAdapter dA = new SqlDataAdapter("ListaPedidosCustomer", cnn))
            {
                dA.SelectCommand.CommandType = CommandType.StoredProcedure;
                dA.SelectCommand.Parameters.AddWithValue("@CustomerID", codigoCliente.ToString());
                dA.Fill(dT);
            }

            cnn.Close();
            return dT;
        }

    }
}