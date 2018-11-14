using CHSARP_MVC_WEB.MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CHSARP_MVC_WEB.CONTROLADOR
{
    public class CPrivilegio
    {
        SqlConnection cnn = new SqlConnection("Data Source=(local);DataBase=BD_Veterinaria;user='sa';pwd='whoami'");
        DataTable dT = new DataTable();

        public DataTable listarPrivilegio()
        {
            using (SqlDataAdapter dA = new SqlDataAdapter("sp_ListarPrivilegio", cnn))
            {
                dA.SelectCommand.CommandType = CommandType.StoredProcedure;
                cnn.Open();
                dA.Fill(dT);
            }
            return dT;
        }


        public void AddCategoria(MPrivilegio p)
        {
            using (SqlCommand cmd = new SqlCommand("sp_AddPrivilegio", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name_privilegio", p.Name_privilegio.ToString());
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
    }
}