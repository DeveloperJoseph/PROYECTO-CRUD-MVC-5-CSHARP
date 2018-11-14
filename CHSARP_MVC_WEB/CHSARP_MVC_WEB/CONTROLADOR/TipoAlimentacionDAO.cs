using CHSARP_MVC_WEB.MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CHSARP_MVC_WEB.CONTROLADOR
{
    public class TipoAlimentacionDAO
    {
        SqlConnection cnn = new SqlConnection("Data Source=(local);DataBase=BD_Veterinaria;user='sa';pwd='whoami'");

        DataTable dT = new DataTable();
        public DataTable ListarTipoAlimentacion()
        {
            using (SqlDataAdapter dA = new SqlDataAdapter("sp_ListarTipoAlimentacion", cnn))
            {
                dA.SelectCommand.CommandType = CommandType.StoredProcedure;
                dA.Fill(dT);
            }
            return dT;
        }

        public void AddTipoAlimentacion(TipoAlimentacion tA)
        {
            using (SqlCommand cmd = new SqlCommand("sp_AddTipoAlimentacion", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desc_tipo_raz", tA.desc_tipo_raz);
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateTipoAlimentacion(TipoAlimentacion tA)
        {
            using (SqlCommand cmd = new SqlCommand("sp_UpdateTipoAlimentacion", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desc_tipo_raz", tA.desc_tipo_raz);
                cmd.Parameters.AddWithValue("@id_tipo_ali", tA.id_tipo_ali);
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTipoAlimentacion(TipoAlimentacion tA)
        {
            using (SqlCommand cmd = new SqlCommand("sp_DeleteTipoAlimentacion", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tipo_ali", tA.id_tipo_ali);
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}