using CHSARP_MVC_WEB.MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CHSARP_MVC_WEB.CONTROLADOR
{
    public class MascotaDAO
    {
        //CONEXION A NUESTRA BASE DE DATOS
        SqlConnection cn = new SqlConnection("Data Source=(local);DataBase=BD_Veterinaria;user='sa';pwd='whoami'");
        //SqlCommand cmd;//COMANDO PARA LANZAR STORE PROCEDURE CONSULTA SQL
        //SqlDataAdapter dA;

        DataTable dT = new DataTable();
        public DataTable ListarMascota()
        {
            using (SqlDataAdapter dA = new SqlDataAdapter("sp_ListarMascotas", cn))
            {
                dA.SelectCommand.CommandType = CommandType.StoredProcedure;
                dA.Fill(dT);
            }
            return dT;
        }


        public void AgregarMascota(Mascota m)
        {
            using (SqlCommand cmd = new SqlCommand("sp_AddMascota", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nomb_mascota", m.nomb_mascota);
                cmd.Parameters.AddWithValue("@peso_kg_mascota", m.peso_kg_mascota);
                cmd.Parameters.AddWithValue("@id_raza", m.id_raza);
                cmd.Parameters.AddWithValue("@id_tipo_ali", m.id_tipo_ali);
                cn.Open(); //Establecemos conexion
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void UpdateMascota(Mascota m)
        {
            using (SqlCommand cmd = new SqlCommand("sp_UpdateMascota", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nomb_mascota", m.nomb_mascota);
                cmd.Parameters.AddWithValue("@peso_kg_mascota", m.peso_kg_mascota);
                cmd.Parameters.AddWithValue("@id_raza",m.id_raza);
                cmd.Parameters.AddWithValue("@id_tipo_ali",m.id_tipo_ali);
                cmd.Parameters.AddWithValue("@id_mascota", m.id_mascota);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteMascota(Mascota m)
        {
            using (SqlCommand cmd = new SqlCommand("sp_DeleteMascota", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mascota", m.id_mascota);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}