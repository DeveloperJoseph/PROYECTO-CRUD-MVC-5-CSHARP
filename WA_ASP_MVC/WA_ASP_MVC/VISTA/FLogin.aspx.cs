using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WA_ASP_MVC.MODELO;

namespace WA_ASP_MVC.VISTA
{
    public partial class FLogin : System.Web.UI.Page
    {
        CONTROLADOR.CUsuario objUser = new CONTROLADOR.CUsuario();
        MUsuario u = new MUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcceder_Click(object sender, EventArgs e)
        {
            u.tipoUser = DropDownList1.SelectedValue.ToString();
            u.emailUser = txtEmail.Text;
            u.passwordUser = txtPassword.Text;
            DataTable n = objUser.LogeoUsuario();
            if (n.Rows.Count == 1)
            {
                Response.Redirect("FMENU_PRINCIPAL", true);
            }
            else
            {
                Response.Redirect("FLogin", true);
            }
        }
    }
}