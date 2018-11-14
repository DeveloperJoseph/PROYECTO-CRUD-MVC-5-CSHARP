using CHSARP_MVC_WEB.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CHSARP_MVC_WEB.VISTAS
{
    public partial class Login : System.Web.UI.Page
    {

        CONTROLADOR.CUsuario objUser = new CONTROLADOR.CUsuario();
        CONTROLADOR.CPrivilegio objPrivilegio = new CONTROLADOR.CPrivilegio();
        MUsuario u = new MUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                listPrivilegios();
            }
        }

        void listPrivilegios()
        {
            DropDownList1.DataSource = objPrivilegio.listarPrivilegio();
            DropDownList1.DataTextField = "Name_privilegio";
            DropDownList1.DataValueField = "idPrivilegio";
            DropDownList1.DataBind();

        }

        protected void btnAcceder_Click(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedValue.ToString();
            /*
            u.idPrivilegio = Convert.ToInt32(txtPrivilegio.Text);
            u.Email_Usuario = txtEmail.Text;
            u.Password_Usuario = txtPassword.Text;
            DataTable n = objUser.LogeoUsuario();
            if (n.Rows.Count == 1)
            {
                if (u.idPrivilegio == 1)
                {
                    Response.Redirect("FMENU_PRINCIPAL", true);
                }
                if (u.idPrivilegio == 2)
                {
                    Response.Redirect("FMENU_PRINCIPAL_SUPERVISOR", true);
                }
            }
             **/
        }
    }
}