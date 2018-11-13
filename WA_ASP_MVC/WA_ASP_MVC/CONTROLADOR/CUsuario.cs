using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WA_ASP_MVC.MODELO;

namespace WA_ASP_MVC.CONTROLADOR
{
    public class CUsuario
    {
        SqlConnection cnn = new SqlConnection("Data Source=(local);DataBase=bdnotas;user='sa';pwd='whoami'");
        DataTable dT = new DataTable();

        public DataTable LogeoUsuario()
        {
            using (SqlDataAdapter dA = new SqlDataAdapter("sp_LoginUsuario", cnn))
            {
                dA.SelectCommand.CommandType = CommandType.StoredProcedure;
                dA.Fill(dT);
            }
            return dT;
        }

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
        /*
        public void AgregarUser(MUsuario u)
        {
            using (SqlCommand cmd = new SqlCommand("sp_AgregarUser", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nameUser", u.nameUser);
                cmd.Parameters.AddWithValue("@tipoUser", u.tipoUser);
                cmd.Parameters.AddWithValue("@emailUser", u.emailUser);
                cmd.Parameters.AddWithValue("@passwordUser", u.passwordUser);
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }
         */
    }
}