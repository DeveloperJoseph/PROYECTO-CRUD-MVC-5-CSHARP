using CHSARP_MVC_WEB.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CHSARP_MVC_WEB.VISTAS
{
    public partial class AgregarMascota : System.Web.UI.Page
    {
        //OBJETO MASCOTA + REFERENCIA AL CONTROLADOR MascotaDAO
        CONTROLADOR.MascotaDAO objMascota = new CONTROLADOR.MascotaDAO();
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            Mascota m = new Mascota();
            m.nomb_mascota = txtNombreMascota.Text;
            m.peso_kg_mascota = Convert.ToDecimal(txtPeso.Text);
            m.id_raza = Convert.ToInt32(txtCodigoRaza.Text);
            m.id_tipo_ali = Convert.ToInt32(txtTipoAlimentacion.Text);
            objMascota.AgregarMascota(m);
            ListarMascota();
        }

        protected void btnUpdateMascota_Click(object sender, EventArgs e)
        {

            Mascota m = new Mascota();
            m.nomb_mascota = txtNombreMascota.Text;
            m.peso_kg_mascota = Convert.ToDecimal(txtPeso.Text);
            m.id_raza = Convert.ToInt32(txtCodigoRaza.Text);
            m.id_tipo_ali = Convert.ToInt32(txtTipoAlimentacion.Text);
            m.id_mascota = Convert.ToInt32(txtCodigoMascota.Text);
            objMascota.UpdateMascota(m);
            ListarMascota();
        }

        protected void btnDeleteMascota_Click(object sender, EventArgs e)
        {
            Mascota m = new Mascota();
            m.id_mascota = Convert.ToInt32(txtCodigoMascota.Text);
            objMascota.DeleteMascota(m);
            ListarMascota();
        }


       void ListarMascota()
       {
           GridView1.DataSource = objMascota.ListarMascota();
           GridView1.DataBind();
       }

       protected void btnActualizarListado_Click(object sender, EventArgs e)
       {
           ListarMascota();
       }

        public void clearText()
       {
           txtCodigoMascota.Text = string.Empty;
           txtNombreMascota.Text = string.Empty;
           txtPeso.Text = string.Empty;
           txtCodigoRaza.Text = string.Empty;
           txtTipoAlimentacion.Text = string.Empty;
           this.txtCodigoMascota.Focus();
       }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            clearText();
        }


    }
}