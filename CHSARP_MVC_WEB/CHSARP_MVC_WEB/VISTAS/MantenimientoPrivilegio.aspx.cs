using CHSARP_MVC_WEB.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CHSARP_MVC_WEB.VISTAS
{
    public partial class MantenimientoPrivilegio : System.Web.UI.Page
    {
        CONTROLADOR.CPrivilegio objCPrivilegio = new CONTROLADOR.CPrivilegio();
        MPrivilegio p = new MPrivilegio();
        String salidaMensaje;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                ListarPrivilegio();
            }
        }

        void ListarPrivilegio()
        {
            GridViewPrivilegio.DataSource = objCPrivilegio.listarPrivilegio();
            GridViewPrivilegio.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            p.Name_privilegio = txtNombrePrivilegio.Text;
            objCPrivilegio.AddCategoria(p);
            ListarPrivilegio();
            salidaMensaje = "Privilegio agregado exitosamente en la base de datos";
            LabelMensaje.Text = salidaMensaje;
        }

    }
}