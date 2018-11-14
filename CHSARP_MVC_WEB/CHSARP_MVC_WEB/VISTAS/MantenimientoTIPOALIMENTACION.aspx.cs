using CHSARP_MVC_WEB.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CHSARP_MVC_WEB.VISTAS
{
    public partial class MantenimientoTIPOALIMENTACION : System.Web.UI.Page
    {
        //OBJETOS INSTANCIADOS
        CONTROLADOR.TipoAlimentacionDAO objTA = new CONTROLADOR.TipoAlimentacionDAO();
        TipoAlimentacion tA = new TipoAlimentacion();
 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void ListarTipoAlimentacion()
        {
            GridView1.DataSource = objTA.ListarTipoAlimentacion();
            GridView1.DataBind();
        }
        protected void btnListarTipoAli_Click(object sender, EventArgs e)
        {
            ListarTipoAlimentacion();
        }

        protected void btnAgregarTipoAli_Click(object sender, EventArgs e)
        {
            tA.desc_tipo_raz = txtDescripcionTipoAli.Text;
            objTA.AddTipoAlimentacion(tA);
            ListarTipoAlimentacion();
        }

        protected void btnUpdateTipoAli_Click(object sender, EventArgs e)
        {
            tA.desc_tipo_raz = txtDescripcionTipoAli.Text;
            tA.id_tipo_ali = Convert.ToInt32(txtCodigoTipoAli.Text);
            objTA.UpdateTipoAlimentacion(tA);
            ListarTipoAlimentacion();
        }

        protected void btnDeleteTipoAli_Click(object sender, EventArgs e)
        {
            tA.id_tipo_ali = Convert.ToInt32(txtCodigoTipoAli.Text);
            objTA.DeleteTipoAlimentacion(tA);
            ListarTipoAlimentacion();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtCodigoTipoAli.Text = string.Empty;
            txtDescripcionTipoAli.Text = string.Empty;
            this.txtCodigoTipoAli.Focus();
        }
    }
}