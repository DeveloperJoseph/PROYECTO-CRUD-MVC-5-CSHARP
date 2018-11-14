using CHSARP_MVC_WEB.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CHSARP_MVC_WEB.VISTAS
{
    public partial class MantenimientoRAZA : System.Web.UI.Page
    {
        CONTROLADOR.RazaDAO objRaza = new CONTROLADOR.RazaDAO();
        Raza rz = new Raza();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void ListarRaza()
        {
            GridView1.DataSource = objRaza.ListadoRaza();
            GridView1.DataBind();
        }
        

        protected void btnListarRaza_Click(object sender, EventArgs e)
        {
            ListarRaza();
        }

        protected void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            rz.desc_raza = txtDescripcion.Text;
            objRaza.AddRaza(rz);
            ListarRaza();
        }

        protected void btnUpdateRaza_Click(object sender, EventArgs e)
        {
            rz.desc_raza = txtDescripcion.Text;
            rz.id_raza = Convert.ToInt32( txtCodigoRaza.Text);
            objRaza.UpdateRaza(rz);
            ListarRaza();
        }

        protected void btnDeleteRaza_Click(object sender, EventArgs e)
        {
            rz.id_raza = Convert.ToInt32(txtCodigoRaza.Text);
            objRaza.DeleteRaza(rz);
            ListarRaza();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtCodigoRaza.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            this.txtCodigoRaza.Focus();
        }
    }
}