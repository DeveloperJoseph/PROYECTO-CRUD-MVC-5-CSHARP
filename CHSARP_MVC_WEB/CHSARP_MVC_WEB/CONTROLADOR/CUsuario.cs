using CHSARP_MVC_WEB.MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CHSARP_MVC_WEB.CONTROLADOR
{
    public class CUsuario
    {

        SqlConnection cnn = new SqlConnection("Data Source=(local);DataBase=BD_Veterinaria;user='sa';pwd='whoami'");
        DataTable dT = new DataTable();

        public void AgregarUser(MUsuario u)
        {
            using (SqlCommand cmd = new SqlCommand("sp_AddUsuario", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPrivilegio", u.idPrivilegio);
                cmd.Parameters.AddWithValue("@Name_usuario", u.Name_usuario);
                cmd.Parameters.AddWithValue("@Email_Usuario", u.Email_Usuario);
                cmd.Parameters.AddWithValue("@Password_Usuario", u.Password_Usuario);
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /*
        public DataTable LogeoUsuario()
        {
            using (SqlDataAdapter dA = new SqlDataAdapter("sp_LoginUsuario", cnn))
            {
                dA.SelectCommand.CommandType = CommandType.StoredProcedure;
                dA.Fill(dT);
            }
            return dT;
        }


         **/
        /*
        public DataTable LoginUsuario(int idEspecialidad, string email, string password)
        {
            using (SqlDataAdapter dA = new SqlDataAdapter("sp_LoginUsuario", cnn))
            {
                dA.SelectCommand.CommandType = CommandType.StoredProcedure;
                dA.SelectCommand.Parameters.AddWithValue("@idPrivilegio", idEspecialidad.ToString());
                dA.SelectCommand.Parameters.AddWithValue("@idPrivilegio", email.ToString());
                dA.SelectCommand.Parameters.AddWithValue("@idPrivilegio", password.ToString());
                dA.Fill(dT);
            }
            cnn.Close();
            return dT;
        }
       **/

    }
}