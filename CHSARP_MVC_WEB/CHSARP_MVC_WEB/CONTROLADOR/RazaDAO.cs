using CHSARP_MVC_WEB.MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CHSARP_MVC_WEB.CONTROLADOR
{
    public class RazaDAO
    {
        SqlConnection cnn = new SqlConnection("Data Source=(local);DataBase=BD_Veterinaria;user='sa';pwd='whoami'"); 
    
        //Listado Raza en DataTable

        DataTable dT = new DataTable();//new objeto
        public DataTable ListadoRaza()
        {
            using (SqlDataAdapter dA = new SqlDataAdapter("sp_ListarRaza", cnn))
            {
                dA.SelectCommand.CommandType = CommandType.StoredProcedure;
                dA.Fill(dT);
            }
            return dT;
        }

        public void AddRaza(Raza r)
        {
            using (SqlCommand cmd = new SqlCommand("sp_AddRaza", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desc_raza", r.desc_raza);
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateRaza(Raza r)
        {
            using (SqlCommand cmd = new SqlCommand("sp_UpdateRaza", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desc_raza", r.desc_raza);
                cmd.Parameters.AddWithValue("@id_raza", r.id_raza);
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteRaza(Raza r)
        {
            using (SqlCommand cmd = new SqlCommand("sp_DeleteRaza", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_raza", r.id_raza);
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}